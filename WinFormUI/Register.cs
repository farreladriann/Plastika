using AddProdukdanSampah;
using System;
using System.Windows.Forms;
using Npgsql;
using DotNetEnv;
using System.Drawing;
using Guna.UI2.WinForms;

namespace AddProdukdanSampah
{
    public partial class Register : Form
    {
        private string selectedRole;

        public Register(string role)
        {
            InitializeComponent();
            selectedRole = role;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string role = selectedRole;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Format email tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsEmailUsed(email))
            {
                MessageBox.Show("Email ini sudah digunakan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUsernameUsed(username))
            {
                MessageBox.Show("Username sudah digunakan, gunakan username lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedRole == "Vendor Produk")
            {
                VendorAccount vendor = new VendorAccount
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Role = selectedRole
                };
                vendor.InsertVendorAccount();
            }
            else if (selectedRole == "Agen Sampah")
            {
                AgentAccount agen = new AgentAccount
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Role = selectedRole
                };
                agen.InsertAgentAccount();
            }

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            Login login = new Login();
            login.Show();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsEmailUsed(string email)
        {
            Env.TraversePath().Load();
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT COUNT(1) FROM (
                        SELECT email FROM pub_plastika.""Account_Vendor""
                        UNION ALL
                        SELECT email FROM pub_plastika.""Account_Agent""
                    ) AS combined
                    WHERE email = @e";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("e", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool IsUsernameUsed(string username)
        {
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                    SELECT COUNT(1) FROM (
                        SELECT username FROM pub_plastika.""Account_Vendor""
                        UNION ALL
                        SELECT username FROM pub_plastika.""Account_Agent""
                    ) AS combined
                    WHERE username = @u";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // ...existing UI enhancement methods...

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // ...existing code...
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // ...existing code...
        }
    }
}

