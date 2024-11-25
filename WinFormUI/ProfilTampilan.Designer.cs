namespace AddProdukdanSampah
{
    partial class ProfilTampilan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilTampilan));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.mainPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 20;
            this.mainPanel.Controls.Add(this.profilePicture);
            this.mainPanel.Controls.Add(this.lblNameTitle);
            this.mainPanel.Controls.Add(this.lblPhoneTitle);
            this.mainPanel.Controls.Add(this.lblAddressTitle);
            this.mainPanel.Controls.Add(this.lblUsernameTitle);
            this.mainPanel.Controls.Add(this.lblPasswordTitle);
            this.mainPanel.Controls.Add(this.lblEmailTitle);
            this.mainPanel.Controls.Add(this.lblName);
            this.mainPanel.Controls.Add(this.lblPhone);
            this.mainPanel.Controls.Add(this.lblAddress);
            this.mainPanel.Controls.Add(this.lblUsername);
            this.mainPanel.Controls.Add(this.lblPassword);
            this.mainPanel.Controls.Add(this.lblEmail);
            this.mainPanel.Controls.Add(this.btnUpdate);
            this.mainPanel.Controls.Add(this.guna2ControlBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(178)))), ((int)(((byte)(74)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 500);
            this.mainPanel.TabIndex = 0;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.Location = new System.Drawing.Point(350, 30);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(100, 100);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblNameTitle.Location = new System.Drawing.Point(220, 200);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(126, 25);
            this.lblNameTitle.TabIndex = 2;
            this.lblNameTitle.Text = "Nama Lengkap:";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.White;
            this.lblPhoneTitle.Location = new System.Drawing.Point(220, 240);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(103, 25);
            this.lblPhoneTitle.TabIndex = 3;
            this.lblPhoneTitle.Text = "No. Telepon:";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAddressTitle.ForeColor = System.Drawing.Color.White;
            this.lblAddressTitle.Location = new System.Drawing.Point(220, 280);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(70, 25);
            this.lblAddressTitle.TabIndex = 4;
            this.lblAddressTitle.Text = "Alamat:";
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.AutoSize = true;
            this.lblUsernameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsernameTitle.ForeColor = System.Drawing.Color.White;
            this.lblUsernameTitle.Location = new System.Drawing.Point(220, 320);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(95, 25);
            this.lblUsernameTitle.TabIndex = 5;
            this.lblUsernameTitle.Text = "Username:";
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPasswordTitle.ForeColor = System.Drawing.Color.White;
            this.lblPasswordTitle.Location = new System.Drawing.Point(220, 360);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(91, 25);
            this.lblPasswordTitle.TabIndex = 6;
            this.lblPasswordTitle.Text = "Password:";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmailTitle.ForeColor = System.Drawing.Color.White;
            this.lblEmailTitle.Location = new System.Drawing.Point(220, 400);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(59, 25);
            this.lblEmailTitle.TabIndex = 7;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(420, 200);
            this.lblName.MinimumSize = new System.Drawing.Size(250, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(420, 240);
            this.lblPhone.MinimumSize = new System.Drawing.Size(250, 25);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(250, 25);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(420, 280);
            this.lblAddress.MinimumSize = new System.Drawing.Size(250, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(250, 25);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(420, 320);
            this.lblUsername.MinimumSize = new System.Drawing.Size(250, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(250, 25);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(420, 360);
            this.lblPassword.MinimumSize = new System.Drawing.Size(250, 25);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(250, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(420, 400);
            this.lblEmail.MinimumSize = new System.Drawing.Size(250, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(250, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.FillColor = System.Drawing.Color.White;
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(178)))), ((int)(((byte)(74)))));
            this.btnUpdate.Location = new System.Drawing.Point(340, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(752, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 29);
            this.guna2ControlBox1.TabIndex = 15;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click_1);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // ProfilTampilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilTampilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}