using DotNetEnv;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AddProdukdanSampah
{
    public partial class ProfilTampilan : Form
    {
        private string currentUsername;

        public ProfilTampilan(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            Env.Load();
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
                SELECT name, phone, address, username, password, email
                FROM pub_plastika.""Account_Vendor"" 
                WHERE username = @u
                UNION ALL
                SELECT name, phone, address, username, password, email
                FROM pub_plastika.""Account_Agent"" 
                WHERE username = @u";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", currentUsername);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader.IsDBNull(0) ? "Nama tidak tersedia" : reader.GetString(0);
                            lblPhone.Text = reader.IsDBNull(1) ? "Telepon tidak tersedia" : reader.GetString(1);
                            lblAddress.Text = reader.IsDBNull(2) ? "Alamat tidak tersedia" : reader.GetString(2);
                            lblUsername.Text = reader.IsDBNull(3) ? "Username tidak tersedia" : reader.GetString(3);
                            lblPassword.Text = reader.IsDBNull(4) ? "Password tidak tersedia" : reader.GetString(4);
                        }

                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil(currentUsername);
            this.Close();
            profilForm.ShowDialog();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            HalamanUtamaNew halamanUtama = new HalamanUtamaNew(currentUsername);
            halamanUtama.Show();
        }
    }

}
