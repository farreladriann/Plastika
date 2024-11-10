//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Configuration;
//using Npgsql;
//using System.Windows.Forms;
//using System.Data;

//namespace AddProdukdanSampah
//{
//    internal class DatabaseHelper
//    {
//        private static string connstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
//        private static NpgsqlConnection conn;
//        private static NpgsqlCommand cmd;
//        private static string sql = null;

//        public static void InsertTrash(Trashes trash)
//        {
//            try
//            {
//                conn = new NpgsqlConnection(connstring);
//                conn.Open();
//                sql = @"INSERT INTO pub_plastika.""Trashes"" (trash_name, description, quantity, price, trash_image) VALUES (@trash_name, @description, @quantity, @price, @trash_image)";
//                cmd = new NpgsqlCommand(sql, conn);
//                cmd.Parameters.AddWithValue("@trash_name", trash.Trash_Name);
//                cmd.Parameters.AddWithValue("@description", trash.Description);
//                cmd.Parameters.AddWithValue("@quantity", trash.Quantity);
//                cmd.Parameters.AddWithValue("@price", trash.Price);

//                // Mengatur parameter image
//                var imageParameter = new NpgsqlParameter("@trash_image", NpgsqlTypes.NpgsqlDbType.Bytea);
//                if (trash.Trash_Image != null)
//                {
//                    imageParameter.Value = trash.Trash_Image;
//                }
//                else
//                {
//                    imageParameter.Value = DBNull.Value;
//                }
//                cmd.Parameters.Add(imageParameter);

//                // Execute the command and check the result using ExecuteNonQuery
//                int result = cmd.ExecuteNonQuery();
//                if (result > 0)
//                {
//                    MessageBox.Show("Data Sampah Berhasil Ditambahkan");
//                }
//                else
//                {
//                    MessageBox.Show("Data Sampah Gagal Ditambahkan");
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
//            }
//            finally
//            {
//                // Ensure the connection is closed even if an error occurs
//                if (conn != null && conn.State == ConnectionState.Open)
//                {
//                    conn.Close();
//                }
//            }
//        }
//        public static List<Trashes> GetTrashes()
//        {
//            List<Trashes> trashes = new List<
//                Trashes>();
//            using (var conn = new NpgsqlConnection(connstring))
//            {
//                conn.Open();
//                using (var cmd = new NpgsqlCommand(@"SELECT id_trash, trash_name, description, quantity, price, trash_image, id_agent FROM pub_plastika.""Trashes""", conn))
//                {
//                    using (var reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Trashes trash = new Trashes(
//                                reader["trash_name"].ToString(),
//                                reader["description"].ToString(),
//                                (int)reader["quantity"],
//                                (long)reader["price"], // Ubah tipe data ke decimal
//                                (byte[])reader["trash_image"]
//                                //(int)reader["id_agent"]
//                            )
//                            {
//                                //Id_Trash = (int)reader["id_trash"]
//                            };
//                            trashes.Add(trash);
//                        }
//                    }
//                }
//            }
//            return trashes;
//        }



//    }
//}
