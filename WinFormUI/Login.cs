// Login.cs
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Npgsql;
using DotNetEnv;
using Guna.UI2.WinForms;

namespace AddProdukdanSampah
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnNext.MouseEnter += BtnNext_MouseEnter;
            btnNext.MouseLeave += BtnNext_MouseLeave;
            this.FormClosing += Login_FormClosing;

            // Set up gradient background
            this.Paint += Login_Paint;
            this.Resize += (s, e) => this.Invalidate();
        }

        // Gradient background paint event
        private void Login_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(39, 174, 96),
                Color.FromArgb(26, 188, 156),
                LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lgb, this.ClientRectangle);
        }

        // Animation when closing the form
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity > 0.0)
                {
                    this.Opacity -= 0.05;
                }
                else
                {
                    timer.Stop();
                    e.Cancel = false;
                    this.Close();
                }
            };
            timer.Start();
        }

        // Event handler untuk tombol Next
        private void btnNext_Click(object sender, EventArgs e)
        {
            Env.Load();
            string connstring = Env.GetString("DB_URI");

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

        // Hover effect untuk tombol Next
        private void BtnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.FillColor = Color.FromArgb(142, 68, 173); // Warna lebih gelap saat hover
        }

        private void BtnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.FillColor = Color.FromArgb(39, 174, 96); // Warna asli
        }

        

        // Validasi email
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

        // Validasi user dengan database
        private bool IsValidUser(string username, string password, string email)
        {
            Env.TraversePath().Load();
            string connstring = Env.GetString("DB_URI");

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