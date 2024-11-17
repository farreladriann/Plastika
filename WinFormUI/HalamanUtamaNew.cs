using AddProdukdanProduk;
using DotNetEnv;
using Npgsql;
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
        private string userRole;
        private string currentUsername;
        private int currentAccountId;
        public HalamanUtamaNew(string username)
        {
            InitializeComponent();
            LoadData(); // Load both Trashes and Products
            tbSearch.TextChanged += tbSearch_TextChanged; // Add event handler for search text box
            userRole = GetUserRole(username);
            currentUsername = username;
            lblUsername.Text = currentUsername;
            currentAccountId = GetAccountId(username);
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
                pic.Click += (s, e) => { NavigateToOrderPage(trash, currentUsername); };
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
            var maps = new Maps(currentUsername);
            maps.Show();
        }

        private void NavigateToOrderPage(Item item, string username)
        {
            this.Close();
            HalamanOrder orderPage = new HalamanOrder(item, username);
            orderPage.Show();
        }

        private string GetUserRole(string username)
        {
            string role = "";
            string connString = Env.GetString("DB_URI");

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT role FROM pub_plastika.\"Account_Agent\" WHERE username = @u", conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }

                using (var cmd = new NpgsqlCommand("SELECT role FROM pub_plastika.\"Account_Vendor\" WHERE username = @u", conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }

            return role;
        }

        private void btnAddBarang_Click(object sender, EventArgs e)
        {
            
            if (userRole == "Vendor Produk")
            {
                TambahProduk tambahProduk = new TambahProduk(currentUsername, currentAccountId);
                this.Close();
                tambahProduk.Show();
            }
            else if (userRole == "Agen Sampah")
            {
                TambahSampah tambahSampah = new TambahSampah(currentUsername, currentAccountId);
                this.Close();
                tambahSampah.Show();
            }
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            if (IsProfileIncomplete(currentUsername))
            {
                Profil profilForm = new Profil(currentUsername);
                profilForm.ShowDialog();
            }
            else
            {
                ProfilTampilan profilTampilanForm = new ProfilTampilan(currentUsername);
                profilTampilanForm.ShowDialog();
            }
        }


        private bool IsProfileIncomplete(string username)
        {
            Env.TraversePath().Load();
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"
            SELECT COUNT(1) 
            FROM (
                SELECT name, phone, address FROM pub_plastika.""Account_Vendor"" WHERE username = @u
                UNION ALL
                SELECT name, phone, address FROM pub_plastika.""Account_Agent"" WHERE username = @u
            ) AS combined
            WHERE name IS NULL OR phone IS NULL OR address IS NULL";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }

        }
        private int GetAccountId(string username)
        {
            string connString = Env.GetString("DB_URI");
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
            SELECT id_account FROM pub_plastika.""Account_Vendor"" WHERE username = @u
            UNION ALL
            SELECT id_account FROM pub_plastika.""Account_Agent"" WHERE username = @u";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("u", username);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }




    }
}
