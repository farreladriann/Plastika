namespace AddProdukdanSampah
{
    partial class Role
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBack;

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
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.rolePanel = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.roleOptionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rbVendor = new System.Windows.Forms.RadioButton();
            this.rbAgenSampah = new System.Windows.Forms.RadioButton();
            this.selectLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.rolePanel.SuspendLayout();
            this.roleOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.ColumnCount = 3;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainContainer.Controls.Add(this.rolePanel, 1, 1);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 3;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainContainer.Size = new System.Drawing.Size(800, 600);
            this.mainContainer.TabIndex = 0;
            // 
            // rolePanel
            // 
            this.rolePanel.BackColor = System.Drawing.Color.White;
            this.rolePanel.Controls.Add(this.btnNext);
            this.rolePanel.Controls.Add(this.btnBack);
            this.rolePanel.Controls.Add(this.roleOptionsPanel);
            this.rolePanel.Controls.Add(this.selectLabel);
            this.rolePanel.Controls.Add(this.welcomeLabel);
            this.rolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolePanel.Location = new System.Drawing.Point(163, 63);
            this.rolePanel.Name = "rolePanel";
            this.rolePanel.Padding = new System.Windows.Forms.Padding(40);
            this.rolePanel.Size = new System.Drawing.Size(474, 474);
            this.rolePanel.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(311, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(40, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // roleOptionsPanel
            // 
            this.roleOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleOptionsPanel.ColumnCount = 1;
            this.roleOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roleOptionsPanel.Controls.Add(this.rbVendor, 0, 0);
            this.roleOptionsPanel.Controls.Add(this.rbAgenSampah, 0, 1);
            this.roleOptionsPanel.Location = new System.Drawing.Point(43, 180);
            this.roleOptionsPanel.Name = "roleOptionsPanel";
            this.roleOptionsPanel.RowCount = 2;
            this.roleOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.roleOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.roleOptionsPanel.Size = new System.Drawing.Size(388, 150);
            this.roleOptionsPanel.TabIndex = 2;
            // 
            // rbVendor
            // 
            this.rbVendor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbVendor.BackColor = System.Drawing.Color.White;
            this.rbVendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbVendor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbVendor.FlatAppearance.BorderSize = 2;
            this.rbVendor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVendor.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.rbVendor.Location = new System.Drawing.Point(10, 10);
            this.rbVendor.Margin = new System.Windows.Forms.Padding(10);
            this.rbVendor.Name = "rbVendor";
            this.rbVendor.Size = new System.Drawing.Size(368, 55);
            this.rbVendor.TabIndex = 0;
            this.rbVendor.TabStop = true;
            this.rbVendor.Text = "◯  Vendor Produk";
            this.rbVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbVendor.UseVisualStyleBackColor = false;
            this.rbVendor.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbAgenSampah
            // 
            this.rbAgenSampah.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAgenSampah.BackColor = System.Drawing.Color.White;
            this.rbAgenSampah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAgenSampah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAgenSampah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbAgenSampah.FlatAppearance.BorderSize = 2;
            this.rbAgenSampah.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbAgenSampah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAgenSampah.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.rbAgenSampah.Location = new System.Drawing.Point(10, 85);
            this.rbAgenSampah.Margin = new System.Windows.Forms.Padding(10);
            this.rbAgenSampah.Name = "rbAgenSampah";
            this.rbAgenSampah.Size = new System.Drawing.Size(368, 55);
            this.rbAgenSampah.TabIndex = 1;
            this.rbAgenSampah.TabStop = true;
            this.rbAgenSampah.Text = "◯  Agen Sampah";
            this.rbAgenSampah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAgenSampah.UseVisualStyleBackColor = false;
            this.rbAgenSampah.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.selectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.selectLabel.Location = new System.Drawing.Point(38, 120);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(106, 30);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Pilih Role";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.welcomeLabel.Location = new System.Drawing.Point(43, 30);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(388, 60);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "SELAMAT DATANG DI PLASTIKA";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plastika - Choose Role";
            this.mainContainer.ResumeLayout(false);
            this.rolePanel.ResumeLayout(false);
            this.rolePanel.PerformLayout();
            this.roleOptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Panel rolePanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.TableLayoutPanel roleOptionsPanel;
        private System.Windows.Forms.RadioButton rbVendor;
        private System.Windows.Forms.RadioButton rbAgenSampah;
        private System.Windows.Forms.Button btnNext;
    }
}