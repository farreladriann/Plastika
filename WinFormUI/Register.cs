using AddProdukdanSampah;
using System;
using System.Windows.Forms;
using Npgsql;
using DotNetEnv;
using System.Drawing;

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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            Role role = new Role();
            role.Show();
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

        // Add these methods to enhance the UI experience
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Add placeholder text
            SetPlaceholderText(tbUsername, "Enter your username");
            SetPlaceholderText(tbPassword, "Enter your password");
            SetPlaceholderText(tbEmail, "Enter your email address");

            // Add hover effects for buttons
            AddButtonHoverEffects();

            // Add textbox focus effects
            AddTextBoxFocusEffects();
        }

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void AddButtonHoverEffects()
        {
            // Next button hover effect
            btnNext.MouseEnter += (s, e) =>
            {
                btnNext.BackColor = Color.FromArgb(21, 128, 61); // Darker green
            };
            btnNext.MouseLeave += (s, e) =>
            {
                btnNext.BackColor = Color.FromArgb(22, 163, 74); // Original green
            };

            // Back button hover effect
            btnKembali.MouseEnter += (s, e) =>
            {
                btnKembali.BackColor = Color.FromArgb(243, 244, 246); // Light gray
            };
            btnKembali.MouseLeave += (s, e) =>
            {
                btnKembali.BackColor = Color.Transparent;
            };
        }

        private void AddTextBoxFocusEffects()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enter += (s, e) =>
                    {
                        textBox.BackColor = Color.White;
                        Panel borderPanel = new Panel
                        {
                            Height = 2,
                            BackColor = Color.FromArgb(22, 163, 74),
                            Location = new Point(textBox.Left, textBox.Bottom + 2),
                            Width = 0
                        };
                        panel1.Controls.Add(borderPanel);

                        // Animate border
                        Timer timer = new Timer { Interval = 10 };
                        timer.Tick += (st, et) =>
                        {
                            if (borderPanel.Width < textBox.Width)
                            {
                                borderPanel.Width += 30;
                            }
                            else
                            {
                                timer.Stop();
                            }
                        };
                        timer.Start();
                    };

                    textBox.Leave += (s, e) =>
                    {
                        textBox.BackColor = Color.FromArgb(243, 244, 246);
                        foreach (Control c in panel1.Controls)
                        {
                            if (c is Panel p && p.Height == 2)
                            {
                                panel1.Controls.Remove(p);
                                p.Dispose();
                            }
                        }
                    };
                }
            }
        }
    }
}

