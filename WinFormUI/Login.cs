using AddProdukdanSampah;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Npgsql;
using DotNetEnv;

namespace AddProdukdanSampah
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Env.Load();

            string connstring = Env.GetString("DB_URI");
            Console.WriteLine(string.IsNullOrEmpty(connstring) ? "Koneksi string tidak ditemukan." : connstring);

            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Format email tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsValidUser(username, password, email))
            {
                this.Close();
                HalamanUtamaNew halamanutama = new HalamanUtamaNew(username);
                halamanutama.Show();
            }
            else
            {
                MessageBox.Show("Username, password, atau email salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool IsValidUser(string username, string password, string email)
        {
            Env.TraversePath().Load();

            string connstring = Env.GetString("DB_URI");
            Console.WriteLine($"Connection String: {connstring}");
            Console.WriteLine(string.IsNullOrEmpty(connstring) ? "Koneksi string tidak ditemukan." : connstring);


            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
            SELECT COUNT(1) 
            FROM (
                SELECT username, password, email FROM pub_plastika.""Account_Vendor""
                UNION ALL
                SELECT username, password, email FROM pub_plastika.""Account_Agent""
            ) AS combined_accounts
            WHERE username = @u AND password = @p AND email = @e", conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    cmd.Parameters.AddWithValue("p", password);
                    cmd.Parameters.AddWithValue("e", email);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
