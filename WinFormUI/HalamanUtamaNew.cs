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
using WinFormUI;

namespace AddProdukdanSampah
{
    public partial class HalamanUtamaNew : Form
    {
        private List<Trashes> allTrashes; // Store all trash items

        public HalamanUtamaNew()
        {
            InitializeComponent();
            LoadData(); // Panggil LoadData di sini
            tbSearch.TextChanged += tbSearch_TextChanged; // Add event handler for search text box
        }

        private void LoadData()
        {
            allTrashes = DatabaseHelper.GetTrashes(); // Assume this retrieves the data
            DisplayTrashes(allTrashes); // Display all items initially
        }

        private void DisplayTrashes(List<Trashes> trashes)
        {
            flpHalamanUtama.Controls.Clear(); // Clear previous items

            foreach (var trash in trashes)
            {
                // Create a panel for each item
                Panel panel = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(200, 250),
                    Margin = new Padding(20),
                    BackColor = Color.Azure
                };

                // Image setup
                PictureBox pic = new PictureBox();
                if (trash.Trash_Image != null)
                {
                    using (var ms = new MemoryStream(trash.Trash_Image))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
<<<<<<< HEAD
                pic.Size = new Size(180, 180); // Sesuaikan ukuran PictureBox
                pic.Click += (s, e) => { NavigateToOrderPage(trash); };
=======
                pic.Size = new Size(180, 180);
                pic.Location = new Point((panel.Width - pic.Width) / 2, 10);

>>>>>>> main
                panel.Controls.Add(pic);

                // Name label
                Label lblName = new Label
                {
                    Text = trash.Trash_Name,
                    Location = new Point(10, 190),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.Blue
                };
                panel.Controls.Add(lblName);

                // Price label
                Label lblPrice = new Label
                {
                    Text = trash.Price.ToString("C"),
                    Location = new Point(10, 210),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.Green
                };
                panel.Controls.Add(lblPrice);

                // Add the panel to the FlowLayoutPanel
                flpHalamanUtama.Controls.Add(panel);
            }
        }

<<<<<<< HEAD
        private void NavigateToOrderPage(Trashes trash)
        {
            // Implementasi navigasi ke halaman pemesanan
            var orderForm = new HalamanPemesanan(trash);
            orderForm.Show();
=======
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text.ToLower(); // Get search term and convert to lowercase
            var filteredTrashes = allTrashes.Where(trash => trash.Trash_Name.ToLower().Contains(searchTerm)).ToList(); // Filter trash items based on search term
            DisplayTrashes(filteredTrashes); // Display filtered items
        }

        private void pbMaps_Click(object sender, EventArgs e)
        {
            this.Close();
            var maps = new Maps();
            maps.Show();
>>>>>>> main
        }
    }

}
