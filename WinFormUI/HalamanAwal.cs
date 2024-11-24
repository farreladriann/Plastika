using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace AddProdukdanSampah
{
    public partial class HalamanAwal : Form
    {
        private Guna2ShadowForm guna2ShadowForm1;

        public HalamanAwal()
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            // Add shadow effect to the form
            this.guna2ShadowForm1 = new Guna2ShadowForm(this.components);
            this.guna2ShadowForm1.SetShadowForm(this);
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.ShadowColor = Color.FromArgb(39, 174, 96);

            // Configure hover effects for buttons
            ConfigureButtonHoverEffects();

            // Add form load animations
            this.Load += Form_Load;
        }

        private void ConfigureButtonHoverEffects()
        {
            // Sign In button hover effects
            signInButton.MouseEnter += (s, e) =>
            {
                signInButton.FillColor = Color.FromArgb(46, 204, 113);
                signInButton.Cursor = Cursors.Hand;
            };

            signInButton.MouseLeave += (s, e) =>
            {
                signInButton.FillColor = Color.FromArgb(39, 174, 96);
            };

            // Sign Up button hover effects
            signUpButton.MouseEnter += (s, e) =>
            {
                signUpButton.FillColor = Color.FromArgb(39, 174, 96);
                signUpButton.ForeColor = Color.White;
                signUpButton.Cursor = Cursors.Hand;
            };

            signUpButton.MouseLeave += (s, e) =>
            {
                signUpButton.FillColor = Color.White;
                signUpButton.ForeColor = Color.FromArgb(39, 174, 96);
            };
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Initially hide elements for fade in effect
            welcomeLabel.Visible = false;
            descriptionLabel.Visible = false;
            loginPanel.Visible = false;

            // Create fade in animation
            Timer fadeTimer = new Timer
            {
                Interval = 500
            };

            fadeTimer.Tick += (s, args) =>
            {
                welcomeLabel.Visible = true;
                descriptionLabel.Visible = true;
                loginPanel.Visible = true;
                fadeTimer.Stop();
                fadeTimer.Dispose();
            };

            fadeTimer.Start();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            CreateFadeOutTransition(() =>
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            });
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            CreateFadeOutTransition(() =>
            {
                this.Hide();
                Role role = new Role();
                role.Show();
            });
        }

        private void CreateFadeOutTransition(Action onComplete)
        {
            Timer fadeTimer = new Timer
            {
                Interval = 10
            };

            fadeTimer.Tick += (s, args) =>
            {
                this.Opacity -= 0.1;
                if (this.Opacity <= 0)
                {
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                    onComplete?.Invoke();
                }
            };

            fadeTimer.Start();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void logoBox_Click(object sender, EventArgs e)
        {

        }
    }
}