namespace AddProdukdanSampah
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();

            // Main Panel
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.mainPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.profilePicture, this.lblTitle, this.txtName, this.txtPhone, 
                this.txtAddress, this.btnConfirm
            });
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 500);
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);

            // Profile Picture
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.profilePicture.Location = new System.Drawing.Point(150, 50);
            this.profilePicture.Size = new System.Drawing.Size(100, 100);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Title
            this.lblTitle.Text = "Profil";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(165, 170);

            // Name TextBox
            this.txtName.PlaceholderText = "Nama Lengkap";
            this.txtName.Location = new System.Drawing.Point(50, 220);
            this.txtName.Size = new System.Drawing.Size(300, 45);
            this.txtName.BorderRadius = 8;

            // Phone TextBox
            this.txtPhone.PlaceholderText = "No. Telepon";
            this.txtPhone.Location = new System.Drawing.Point(50, 280);
            this.txtPhone.Size = new System.Drawing.Size(300, 45);
            this.txtPhone.BorderRadius = 8;

            // Address TextBox
            this.txtAddress.PlaceholderText = "Alamat";
            this.txtAddress.Location = new System.Drawing.Point(50, 340);
            this.txtAddress.Size = new System.Drawing.Size(300, 45);
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.Multiline = true;

            // Confirm Button
            this.btnConfirm.Text = "Simpan Perubahan";
            this.btnConfirm.Location = new System.Drawing.Point(50, 400);
            this.btnConfirm.Size = new System.Drawing.Size(300, 45);
            this.btnConfirm.BorderRadius = 8;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Initialize Elipse for rounded corners
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;

            // Enable form dragging
            this.guna2DragControl1.DragStartTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.mainPanel;

            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
    }
}