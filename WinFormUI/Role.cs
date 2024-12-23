﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormUI;

namespace AddProdukdanSampah
{
    public partial class Role : Form
    {
        private const int ANIMATION_INTERVAL = 50;
        private readonly Color PRIMARY_COLOR = Color.FromArgb(39, 174, 96);
        private readonly Color SECONDARY_COLOR = Color.FromArgb(52, 86, 69);
        private readonly Font REGULAR_FONT = new Font("Segoe UI", 10.8f, FontStyle.Regular);
        private readonly Font BOLD_FONT = new Font("Segoe UI", 10.8f, FontStyle.Bold);

        public Role()
        {
            InitializeComponent();
            SetupInitialStyles();
            
            // Set fixed size and prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ClientSize = new Size(800, 600); // Fixed size
            this.BackColor = Color.White; // White background
        }

        private void SetupInitialStyles()
        {
            // Set white background for all containers
            this.mainContainer.BackColor = Color.White;
            this.rolePanel.BackColor = Color.White;
            
            // Disable button initially until a role is selected
            btnNext.Enabled = false;
            btnNext.BackColor = Color.FromArgb(200, PRIMARY_COLOR);

            // Set up hover effects for the Next button
            btnNext.MouseEnter += (s, e) => {
                if (btnNext.Enabled)
                    btnNext.BackColor = Color.FromArgb(45, 200, 110);
            };
            btnNext.MouseLeave += (s, e) => {
                if (btnNext.Enabled)
                    btnNext.BackColor = PRIMARY_COLOR;
            };

            // Set up tooltips for role options
            SetupTooltips();
        }

        // Rest of the code remains the same...
        private void SetupTooltips()
        {
            var tooltips = new ToolTip
            {
                InitialDelay = 500,
                ReshowDelay = 100,
                ShowAlways = true,
                ToolTipTitle = "Informasi Role"
            };

            tooltips.SetToolTip(rbVendor,
                "Sebagai Vendor Produk, Anda dapat:\n" +
                "• Menjual produk daur ulang\n" +
                "• Membeli sampah dari agen\n" +
                "• Mengelola katalog produk");

            tooltips.SetToolTip(rbAgenSampah,
                "Sebagai Agen Sampah, Anda dapat:\n" +
                "• Mengumpulkan dan menjual sampah\n" +
                "• Mendapatkan harga terbaik\n" +
                "• Berkontribusi pada lingkungan");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbVendor.Checked || rbAgenSampah.Checked)
            {
                string selectedRole = rbVendor.Checked ? "Vendor Produk" : "Agen Sampah";
                Register registerForm = new Register(selectedRole);
                this.Hide();
                registerForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih salah satu role terlebih dahulu.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HalamanAwal halamanAwal = new HalamanAwal();
            this.Hide();
            halamanAwal.ShowDialog();
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton selectedRadioButton)
            {
                UpdateRadioButtonStyles(selectedRadioButton);
                AnimateSelection(selectedRadioButton);
                UpdateNextButton(true);
            }
        }

        private void UpdateRadioButtonStyles(RadioButton selectedRadioButton)
        {
            foreach (RadioButton radioButton in new[] { rbVendor, rbAgenSampah })
            {
                bool isSelected = radioButton == selectedRadioButton && selectedRadioButton.Checked;

                radioButton.ForeColor = isSelected ? Color.White : SECONDARY_COLOR;
                radioButton.BackColor = isSelected ? PRIMARY_COLOR : Color.White;
                radioButton.Font = isSelected ? BOLD_FONT : REGULAR_FONT;

                string baseText = radioButton.Text.Replace("✓  ", "").Replace("◯  ", "");
                radioButton.Text = isSelected ? $"✓  {baseText}" : $"◯  {baseText}";

                radioButton.FlatAppearance.BorderColor = PRIMARY_COLOR;
            }
        }

        private void AnimateSelection(RadioButton selectedRadioButton)
        {
            var animationTimer = new Timer
            {
                Interval = ANIMATION_INTERVAL
            };

            int pulseCount = 0;
            const int PULSE_STEPS = 2;

            animationTimer.Tick += (s, e) =>
            {
                pulseCount++;
                switch (pulseCount)
                {
                    case 1:
                        selectedRadioButton.Padding = new Padding(5);
                        break;
                    case PULSE_STEPS:
                        selectedRadioButton.Padding = new Padding(0);
                        animationTimer.Stop();
                        animationTimer.Dispose();
                        break;
                }
            };

            animationTimer.Start();
        }

        private void UpdateNextButton(bool enable)
        {
            btnNext.Enabled = enable;
            btnNext.BackColor = enable ? PRIMARY_COLOR : Color.FromArgb(200, PRIMARY_COLOR);
            btnNext.Cursor = enable ? Cursors.Hand : Cursors.Default;
        }
    }
}