using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI;

namespace AddProdukdanSampah
{
    public partial class HalamanAwal : Form
    {
        
        public HalamanAwal()
        { 

            InitializeComponent();
           
        }

        private void linklblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Role role = new Role();
            role.Show();
        }

        private void featuresPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

