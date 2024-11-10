using System;
using System.Collections.Generic;
using System.Data;
using Npgsql; // Make sure you reference this
using System.Windows.Forms;
using System.Configuration;

namespace AddProdukdanSampah
{
    internal class Trashes : Item
    {
        private static string connstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        // Add a property for agent ID if necessary
        // public int Id_Agent { get; set; }

        // Constructor
        public Trashes(string name, string description, int quantity, long price, byte[] image)
            : base(name, description, quantity, price, image) // Call base class constructor
        { }

        // Insert method
        public static void InsertTrash(Trashes trash)
        {
            using (var conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO pub_plastika.""Trashes"" (trash_name, description, quantity, price, trash_image) 
                                   VALUES (@trash_name, @description, @quantity, @price, @trash_image)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@trash_name", trash.Name);
                        cmd.Parameters.AddWithValue("@description", trash.Description);
                        cmd.Parameters.AddWithValue("@quantity", trash.Quantity);
                        cmd.Parameters.AddWithValue("@price", trash.Price);

                        // Handling image parameter
                        var imageParameter = new NpgsqlParameter("@trash_image", NpgsqlTypes.NpgsqlDbType.Bytea);
                        if (trash.Image != null)
                        {
                            imageParameter.Value = trash.Image;
                        }
                        else
                        {
                            imageParameter.Value = DBNull.Value;
                        }

                        
                        cmd.Parameters.Add(imageParameter);

                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Data Sampah Berhasil Ditambahkan" : "Data Sampah Gagal Ditambahkan");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
                }
            }
        }

        // Retrieve method
        public static List<Trashes> GetTrashes()
        {
            List<Trashes> trashes = new List<Trashes>();
            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"SELECT id_trash, trash_name, description, quantity, price, trash_image FROM pub_plastika.""Trashes""", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var trash = new Trashes(
                                reader["trash_name"].ToString(),
                                reader["description"].ToString(),
                                (int)reader["quantity"],
                                (long)reader["price"],
                                reader["trash_image"] as byte[] // Explicitcast to byte[]
                            )
                            {
                                Id = (int)reader["id_trash"] // Assuming you have an Id for reference
                            };
                            trashes.Add(trash);
                        }
                    }
                }
            }
            return trashes;
        }
    }
}
