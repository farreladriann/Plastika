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
        private List<Products> allProducts; // Store all product items

        public HalamanUtamaNew()
        {
            InitializeComponent();
            LoadData(); // Load both Trashes and Products
            tbSearch.TextChanged += tbSearch_TextChanged; // Add event handler for search text box
        }

        private void LoadData()
        {
            allTrashes = Trashes.GetTrashes(); // Load trash items
            allProducts = Products.GetProducts(); // Load product items
            DisplayItems(); // Display both items
        }

        private void DisplayItems()
        {
            flpHalamanUtama.Controls.Clear(); // Clear previous items

            DisplayTrashes(allTrashes); // Display all trash items
            DisplayProducts(allProducts); // Display all product items
        }

        private void DisplayTrashes(List<Trashes> trashes)
        {
            foreach (var trash in trashes)
            {
                // Create a panel for each trash item
                Panel panel = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(200, 250),
                    Margin = new Padding(20),
                    BackColor = Color.Azure
                };

                // Setup image
                PictureBox pic = new PictureBox();
                if (trash.Image != null)
                {
                    using (var ms = new MemoryStream(trash.Image))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new Size(180, 180);
                pic.Click += (s, e) => { NavigateToOrderPage(trash); };
                pic.Location = new Point((panel.Width - pic.Width) / 2, 10);

                panel.Controls.Add(pic);

                // Name label
                Label lblName = new Label
                {
                    Text = trash.Name,
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

        // New method to display products
        private void DisplayProducts(List<Products> products)
        {
            foreach (var product in products)
            {
                // Create a panel for each product item
                Panel panel = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(200, 250),
                    Margin = new Padding(20),
                    BackColor = Color.LightYellow
                };

                // Setup image
                PictureBox pic = new PictureBox();
                if (product.Image != null)
                {
                    using (var ms = new MemoryStream(product.Image))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new Size(180, 180);
                pic.Location = new Point((panel.Width - pic.Width) / 2, 10);
                pic.Click += (s, e) => { NavigateToOrderPage(product); };
                panel.Controls.Add(pic);

                // Name label
                Label lblName = new Label
                {
                    Text = product.Name,
                    Location = new Point(10, 190),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.Blue
                };
                panel.Controls.Add(lblName);

                // Price label
                Label lblPrice = new Label
                {
                    Text = product.Price.ToString("C"),
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearch.Text.ToLower(); // Get search term and convert to lowercase

            // Filter items based on the search term
            var filteredTrashes = allTrashes.Where(trash => trash.Name.ToLower().Contains(searchTerm)).ToList();
            var filteredProducts = allProducts.Where(product => product.Name.ToLower().Contains(searchTerm)).ToList();

            // Clear the FlowLayoutPanel before displaying filtered results
            flpHalamanUtama.Controls.Clear();

            // Display filtered trash items
            DisplayTrashes(filteredTrashes);

            // Display filtered product items
            DisplayProducts(filteredProducts);
        }


        private void pbMaps_Click(object sender, EventArgs e)
        {
            this.Close();
            var maps = new Maps();
            maps.Show();
        }

        private void NavigateToOrderPage(Item item)
        {
            this.Close();
            var orderPage = new HalamanOrder(item);
            orderPage.Show();
        }



    }
}
