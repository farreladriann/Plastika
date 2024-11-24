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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanAwal));
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.accountLabel = new System.Windows.Forms.Label();
            this.signInLink = new System.Windows.Forms.LinkLabel();
            this.orLabel = new System.Windows.Forms.Label();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Controls.Add(this.welcomeLabel, 0, 0);
            this.mainContainer.Controls.Add(this.logoBox, 0, 1);
            this.mainContainer.Controls.Add(this.titleLabel, 0, 2);
            this.mainContainer.Controls.Add(this.descriptionLabel, 0, 3);
            this.mainContainer.Controls.Add(this.loginPanel, 0, 4);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(30);
            this.mainContainer.RowCount = 5;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainContainer.Size = new System.Drawing.Size(800, 700);
            this.mainContainer.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.welcomeLabel.Location = new System.Drawing.Point(33, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(734, 96);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // logoBox
            // 
            this.logoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(257, 130);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(285, 216);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.titleLabel.Location = new System.Drawing.Point(33, 350);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(734, 128);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Plastika";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(91)))));
            this.descriptionLabel.Location = new System.Drawing.Point(33, 478);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(734, 96);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Your sustainable marketplace for waste collection and recycled products";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.loginPanel.Controls.Add(this.accountLabel);
            this.loginPanel.Controls.Add(this.signInLink);
            this.loginPanel.Controls.Add(this.orLabel);
            this.loginPanel.Controls.Add(this.signUpLink);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(33, 577);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(734, 90);
            this.loginPanel.TabIndex = 5;
            // 
            // accountLabel
            // 
            this.accountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.accountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.accountLabel.Location = new System.Drawing.Point(220, 35);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(228, 25);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Already have an account?";
            // 
            // signInLink
            // 
            this.signInLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInLink.AutoSize = true;
            this.signInLink.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.signInLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signInLink.Location = new System.Drawing.Point(397, 35);
            this.signInLink.Name = "signInLink";
            this.signInLink.Size = new System.Drawing.Size(70, 25);
            this.signInLink.TabIndex = 1;
            this.signInLink.TabStop = true;
            this.signInLink.Text = "Sign in";
            this.signInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSignIn_LinkClicked);
            // 
            // orLabel
            // 
            this.orLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.orLabel.Location = new System.Drawing.Point(454, 35);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(30, 25);
            this.orLabel.TabIndex = 2;
            this.orLabel.Text = "or";
            // 
            // signUpLink
            // 
            this.signUpLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLink.AutoSize = true;
            this.signUpLink.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.signUpLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.signUpLink.Location = new System.Drawing.Point(473, 35);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(76, 25);
            this.signUpLink.TabIndex = 3;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Sign up";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSignUp_LinkClicked);
            // 
            // HalamanAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(600, 650);
            this.Name = "HalamanAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plastika - Sustainable Waste Management";
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.LinkLabel signInLink;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.LinkLabel signUpLink;
    }
}