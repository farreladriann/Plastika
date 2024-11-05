using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProdukdanSampah
{
    public partial class HalamanUtama : Form
    {

        public HalamanUtama()
        {
            InitializeComponent();
            
        }

        public void UpdateTrashDisplay(byte[] trashImage, string trashName)
        {
            // Update the label to show the trash name
            lblHasilSampah.Text = trashName;

            // Convert byte array to image and display in PictureBox
            using (MemoryStream ms = new MemoryStream(trashImage))
            {
                pbHasilSampah.Image = Image.FromStream(ms);
            }
        }




    }
}
