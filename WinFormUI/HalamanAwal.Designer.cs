namespace AddProdukdanSampah
{
    partial class HalamanAwal
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
        /// Required method for Designer support. Do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanAwal));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signInButton = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.leftPanel.Controls.Add(this.logoBox);
            this.leftPanel.Controls.Add(this.titleLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(400, 653);
            this.leftPanel.TabIndex = 0;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(75, 200);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(250, 250);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 470);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(400, 70);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Plastika";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.welcomeLabel);
            this.rightPanel.Controls.Add(this.descriptionLabel);
            this.rightPanel.Controls.Add(this.loginPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(400, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(60);
            this.rightPanel.Size = new System.Drawing.Size(582, 653);
            this.rightPanel.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.welcomeLabel.Location = new System.Drawing.Point(60, 150);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(480, 60);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Plastika";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.descriptionLabel.Location = new System.Drawing.Point(63, 220);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(480, 120);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Your sustainable marketplace for waste collection and recycled products. Join us " +
    "in creating a better environment through responsible waste management.";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.signInButton);
            this.loginPanel.Controls.Add(this.orLabel);
            this.loginPanel.Controls.Add(this.signUpButton);
            this.loginPanel.Location = new System.Drawing.Point(60, 360);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(480, 200);
            this.loginPanel.TabIndex = 2;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(0, 0);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(480, 50);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            this.signInButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.signInButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.orLabel.Location = new System.Drawing.Point(230, 70);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(30, 25);
            this.orLabel.TabIndex = 1;
            this.orLabel.Text = "or";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.White;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signUpButton.Location = new System.Drawing.Point(0, 110);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(480, 50);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Create New Account";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            this.signUpButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.signUpButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // HalamanAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HalamanAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plastika";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button signUpButton;
    }
}
