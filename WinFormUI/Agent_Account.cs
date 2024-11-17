using System;
using System.Collections.Generic;
using Npgsql;
using DotNetEnv;

namespace AddProdukdanSampah
{
    internal class AgentAccount : Account
    {
        public void InsertAgentAccount()
        {

            Env.TraversePath().Load();

            string connstring = Env.GetString("DB_URI");
            Console.WriteLine(string.IsNullOrEmpty(connstring) ? "Koneksi string tidak ditemukan." : connstring);

            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"INSERT INTO pub_plastika.""Account_Agent"" (username, password, email, role) VALUES (@u, @p, @e, @r)", conn))
                {
                    cmd.Parameters.AddWithValue("u", Username);
                    cmd.Parameters.AddWithValue("p", Password);
                    cmd.Parameters.AddWithValue("e", Email);
                    cmd.Parameters.AddWithValue("r", Role);   
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method untuk mendapatkan semua akun vendor dari database

        // Method untuk mendapatkan semua akun dari database
        public static List<Account> GetAccountsVendor()
        {
            var accounts = new List<Account>();

            Env.Load();

            string connstring = Env.GetString("DB_URI");
            Console.WriteLine(string.IsNullOrEmpty(connstring) ? "Koneksi string tidak ditemukan." : connstring);


            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"SELECT id, username, password, email, role FROM pub_plastika.""Account_Agent""", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(new Account
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                            Email = reader.GetString(4),
                            Role = reader.GetString(5)
                        });
                    }
                }
            }

            return accounts;
        }
            public void InsertAgentProfile()
            {

                Env.TraversePath().Load();

                string connstring = Env.GetString("DB_URI");
                Console.WriteLine(string.IsNullOrEmpty(connstring) ? "Koneksi string tidak ditemukan." : connstring);

                using (var conn = new NpgsqlConnection(connstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(@"INSERT INTO pub_plastika.""Account_Agent"" (name, phone, address) VALUES (@n, @p, @a)", conn))
                    {
                        cmd.Parameters.AddWithValue("n", Name);
                        cmd.Parameters.AddWithValue("p", Phone);
                        cmd.Parameters.AddWithValue("a", Address);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
    }
}
   