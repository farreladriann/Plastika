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
using Npgsql;
using DotNetEnv;
using System.Configuration;
using AddProdukdanSampah;

namespace AddProdukdanProduk
{
    public partial class TambahProduk : Form
    {
        private HalamanUtamaNew mainForm;
        private string currentUsername;
        private int currentAccountId;
        

        public TambahProduk(string username, int accountId)
        {
            InitializeComponent();
            currentUsername = username;
            currentAccountId = accountId; // Simpan id_account
            
        }


        //private NpgsqlConnection conn;
        //string connstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        //public static NpgsqlCommand cmd;
        //private string sql = null;
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    conn = new NpgsqlConnection(connstring);

        //}



        private void btnUploadFotoProduk_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                tbFotoProduk.Text = opf.FileName;
                pbFotoProduk.Image = new Bitmap(opf.FileName);
            }
        }
        //private int GetRoleId(int accountId)
        //{
        //    string connString = Env.GetString("DB_URI");
        //    using (var conn = new NpgsqlConnection(connString))
        //    {
        //        conn.Open();
        //        string query = @"
        //SELECT id FROM pub_plastika.""Account_Vendor""
        //WHERE id_account = @accountId";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@accountId", accountId);
        //            return Convert.ToInt32(cmd.ExecuteScalar());
        //        }
        //    }
        //}


        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbNamaProduk.Text;
                string description = tbDeskripsiProduk.Text;
                int quantity = int.Parse(tbKuantitasProduk.Text);
                long price = long.Parse(tbHargaProduk.Text);
                byte[] imageBytes = null;

                if (pbFotoProduk.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFotoProduk.Image.Save(ms, pbFotoProduk.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                Products newProduct = new Products(currentAccountId, name, description, quantity, price, imageBytes);

                Products.InsertProduct(newProduct, currentAccountId);

                MessageBox.Show("Data berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
            }
        }





        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide(); // Kembali ke halaman utama
            HalamanUtamaNew halamanUtama = new HalamanUtamaNew(currentUsername);
            halamanUtama.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }







        //    private void btnKembali_Click(object sender, EventArgs e)
        //{
        //    // Get the trash name and image from the input fields
        //    string trashName = tbNamaProduk.Text;
        //    byte[] trashImage = GetImageBytesFromPictureBox(pbFotoProduk);

        //    // Show the main form and update its display
        //    mainForm.Show();
        //    mainForm.UpdateTrashDisplay(trashImage, trashName);

        //    mainForm.BringToFront();

        //    // Close the current form (TambahProduk)
        //    this.Hide();
        //}

        //// Helper function to convert PictureBox image to byte array
        //private byte[] GetImageBytesFromPictureBox(PictureBox pictureBox)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
        //        return ms.ToArray();
        //    }
        //}







    }
}
