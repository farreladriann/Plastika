using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI;

namespace AddProdukdanSampah
{
    public partial class Role : Form
    {
        
        public Role()
        {
            InitializeComponent();
            
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
                MessageBox.Show("Silakan pilih salah satu role.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
