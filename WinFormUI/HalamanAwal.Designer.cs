namespace AddProdukdanSampah
{
    partial class HalamanAwal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanAwal));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.welcomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.descriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.loginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.signInButton = new Guna.UI2.WinForms.Guna2Button();
            this.orLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.signUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
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
            this.guna2DragControl1.TargetControl = this.leftPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.leftPanel.Controls.Add(this.logoBox);
            this.leftPanel.Controls.Add(this.titleLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 500);
            this.leftPanel.TabIndex = 1;
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BorderRadius = 125;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.ImageRotate = 0F;
            this.logoBox.Location = new System.Drawing.Point(25, 80);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(250, 250);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(85, 340);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(150, 56);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Plastika";
            this.titleLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.welcomeLabel);
            this.rightPanel.Controls.Add(this.descriptionLabel);
            this.rightPanel.Controls.Add(this.loginPanel);
            this.rightPanel.Controls.Add(this.guna2ControlBox1);
            this.rightPanel.Controls.Add(this.guna2ControlBox2);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(300, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(40);
            this.rightPanel.Size = new System.Drawing.Size(400, 500);
            this.rightPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.welcomeLabel.Location = new System.Drawing.Point(40, 100);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(284, 47);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Plastika";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.descriptionLabel.Location = new System.Drawing.Point(40, 155);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(382, 25);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Your sustainable marketplace for\r\nwaste collection.";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.signInButton);
            this.loginPanel.Controls.Add(this.orLabel);
            this.loginPanel.Controls.Add(this.signUpButton);
            this.loginPanel.Location = new System.Drawing.Point(40, 250);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(320, 150);
            this.loginPanel.TabIndex = 2;
            // 
            // signInButton
            // 
            this.signInButton.BorderRadius = 8;
            this.signInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signInButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(0, 0);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(320, 40);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // orLabel
            // 
            this.orLabel.BackColor = System.Drawing.Color.Transparent;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.orLabel.Location = new System.Drawing.Point(150, 55);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(19, 25);
            this.orLabel.TabIndex = 1;
            this.orLabel.Text = "or";
            // 
            // signUpButton
            // 
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signUpButton.BorderRadius = 8;
            this.signUpButton.BorderThickness = 1;
            this.signUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpButton.FillColor = System.Drawing.Color.White;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signUpButton.Location = new System.Drawing.Point(0, 95);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(320, 40);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Create New Account";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(355, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(304, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // HalamanAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HalamanAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plastika";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private Guna.UI2.WinForms.Guna2PictureBox logoBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2Panel rightPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcomeLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel descriptionLabel;
        private Guna.UI2.WinForms.Guna2Panel loginPanel;
        private Guna.UI2.WinForms.Guna2Button signInButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel orLabel;
        private Guna.UI2.WinForms.Guna2Button signUpButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}

