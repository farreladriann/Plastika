// Login.Designer.cs
namespace AddProdukdanSampah
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

        /// <summary>
        /// Bersihkan semua resource yang sedang digunakan.
        /// </summary>
        /// <param name="disposing">
        /// True jika managed resources harus dibuang; sebaliknya, False.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kode yang dihasilkan oleh Windows Form Designer

        /// <summary>
        /// Metode yang diperlukan untuk dukungan Designer - jangan modifikasi
        /// konten metode ini dengan editor kode.
        /// </summary>
        private void InitializeComponent()
        {
            // Inisialisasi komponen
            this.components = new System.ComponentModel.Container();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(400, 500);
            this.panel1.TabIndex = 0;

            // 
            // label1 (Title)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(50, 130);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";

            // 
            // tbUsername
            // 
            this.tbUsername.BorderRadius = 15;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.Location = new System.Drawing.Point(150, 125);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "Enter Username";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(200, 36);
            this.tbUsername.TabIndex = 2;

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(50, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";

            // 
            // tbPassword
            // 
            this.tbPassword.BorderRadius = 15;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(150, 175);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.PlaceholderText = "Enter Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(200, 36);
            this.tbPassword.TabIndex = 4;

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(50, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";

            // 
            // tbEmail
            // 
            this.tbEmail.BorderRadius = 15;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(150, 225);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Enter Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(200, 36);
            this.tbEmail.TabIndex = 6;

            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 15;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(150, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(200, 45);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            this.guna2Elipse1.BorderRadius = 30;

            // 
            // Login (Form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}