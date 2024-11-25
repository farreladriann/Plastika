namespace AddProdukdanSampah
{
    partial class HalamanUtamaNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtamaNew));
            this.flpHalamanUtama = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbMaps = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddBarang = new Guna.UI2.WinForms.Guna2Button();
            this.pbProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // flpHalamanUtama
            // 
            this.flpHalamanUtama.AutoScroll = true;
            this.flpHalamanUtama.AutoSize = true;
            this.flpHalamanUtama.Location = new System.Drawing.Point(16, 75);
            this.flpHalamanUtama.Margin = new System.Windows.Forms.Padding(7);
            this.flpHalamanUtama.MaximumSize = new System.Drawing.Size(2000, 900);
            this.flpHalamanUtama.Name = "flpHalamanUtama";
            this.flpHalamanUtama.Size = new System.Drawing.Size(764, 600);
            this.flpHalamanUtama.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Location = new System.Drawing.Point(16, 12);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Search";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(500, 36);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pbMaps
            // 
            this.pbMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaps.Image = ((System.Drawing.Image)(resources.GetObject("pbMaps.Image")));
            this.pbMaps.ImageRotate = 0F;
            this.pbMaps.Location = new System.Drawing.Point(1100, 12);
            this.pbMaps.Name = "pbMaps";
            this.pbMaps.Size = new System.Drawing.Size(45, 44);
            this.pbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaps.TabIndex = 1;
            this.pbMaps.TabStop = false;
            this.pbMaps.Click += new System.EventHandler(this.pbMaps_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 2;
            // 
            // btnAddBarang
            // 
            this.btnAddBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBarang.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBarang.BorderRadius = 10;
            this.btnAddBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBarang.FillColor = System.Drawing.Color.LightGreen;
            this.btnAddBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBarang.ForeColor = System.Drawing.Color.White;
            this.btnAddBarang.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnAddBarang.Location = new System.Drawing.Point(1100, 700);
            this.btnAddBarang.Name = "btnAddBarang";
            this.btnAddBarang.Size = new System.Drawing.Size(120, 50);
            this.btnAddBarang.TabIndex = 0;
            this.btnAddBarang.Text = "Add Barang";
            this.btnAddBarang.Click += new System.EventHandler(this.btnAddBarang_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.ImageRotate = 0F;
            this.pbProfile.Location = new System.Drawing.Point(1150, 12);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(44, 44);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 4;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(1200, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 18);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // HalamanUtamaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbMaps);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.btnAddBarang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpHalamanUtama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HalamanUtamaNew";
            this.Text = "HalamanUtamaNew";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HalamanUtamaNew_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHalamanUtama;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2PictureBox pbMaps;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddBarang;
        private Guna.UI2.WinForms.Guna2PictureBox pbProfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
    }
}