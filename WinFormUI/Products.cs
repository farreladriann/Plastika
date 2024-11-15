using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProdukdanSampah
{
    internal class Products : Item
    {
        private static string connstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        //Constructor
        public Products(string name, string description, int quantity, long price, byte[] iamge)
                : base(name, description, quantity, price, iamge) { }

        public static void InsertProduct(Products product)
        {
            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO pub_plastika.""Products"" (products_name, description, quantity, price, images_product)
                           VALUES (@name, @description, @quantity, @price, @image)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", product.Name);
                        cmd.Parameters.AddWithValue("@description", product.Description);
                        cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                        cmd.Parameters.AddWithValue("@price", product.Price);

                        var imageParameter = new NpgsqlParameter("@image", NpgsqlTypes.NpgsqlDbType.Bytea);
                        if (product.Image != null)
                        {
                            imageParameter.Value = product.Image;
                        }
                        else {
                            imageParameter.Value = DBNull.Value;
                        }
                        cmd.Parameters.Add(imageParameter);

                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Data Produk Berhasil Ditambahkan" : "Data Produk Gagal Ditambahkan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
                }
            }
        }



        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"SELECT id_product, products_name, description, quantity, price, images_product FROM pub_plastika.""Products""", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Products(
                                reader["products_name"].ToString(),
                                reader["description"].ToString(),
                                (int)reader["quantity"],
                                (long)reader["price"],
                                reader["images_product"] as byte[] // Explicitcast to byte[]
                            )
                            {
                                Id = (int)reader["id_product"] // Assuming you have an Id for reference
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;

        }

    }
   
    
}
