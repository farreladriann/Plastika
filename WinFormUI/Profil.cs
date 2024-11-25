using DotNetEnv;
using Npgsql;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AddProdukdanSampah
{
    public partial class Profil : Form
    {
        private string currentUsername;

        public Profil(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Masukkan nomor telepon yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateProfile(currentUsername, name, phone, address);
            MessageBox.Show("Profil berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool IsValidPhone(string phone)
        {
            // Contoh regex sederhana untuk nomor telepon
            string pattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phone, pattern);
        }

        private void UpdateProfile(string username, string name, string phone, string address)
        {
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                UPDATE pub_plastika.""Account_Vendor"" 
                SET name = @n, phone = @p, address = @a 
                WHERE username = @u;
                
                UPDATE pub_plastika.""Account_Agent"" 
                SET name = @n, phone = @p, address = @a 
                WHERE username = @u;";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    cmd.Parameters.AddWithValue("n", name);
                    cmd.Parameters.AddWithValue("p", phone);
                    cmd.Parameters.AddWithValue("a", address);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
