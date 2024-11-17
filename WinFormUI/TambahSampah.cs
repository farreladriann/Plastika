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

namespace AddProdukdanSampah
{
    public partial class TambahSampah : Form
    {
        private HalamanUtamaNew mainForm;
        private string currentUsername;
        private int currentAccountId;
        

        public TambahSampah(string username, int accountId)
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

        //private int GetRoleId(int accountId)
        //{
        //    string connString = Env.GetString("DB_URI");
        //    using (var conn = new NpgsqlConnection(connString))
        //    {
        //        conn.Open();
        //        string query = @"
        //SELECT id_role FROM pub_plastika.""Account_Vendor""
        //WHERE id_account = @accountId";

        //        using (var cmd = new NpgsqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@accountId", accountId);
        //            return Convert.ToInt32(cmd.ExecuteScalar());
        //        }
        //    }
        //}

        private void btnUploadFotoSampah_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                tbFotoSampah.Text = opf.FileName;
                pbFotoSampah.Image = new Bitmap(opf.FileName);
            }
        }



        private void btnTambahSampah_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbNamaSampah.Text;
                string description = tbDeskripsiSampah.Text;
                int quantity = int.Parse(tbKuantitasSampah.Text);
                long price = long.Parse(tbHargaSampah.Text);
                byte[] imageBytes = null;

                if (pbFotoSampah.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFotoSampah.Image.Save(ms, pbFotoSampah.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                Trashes newTrash = new Trashes(currentAccountId, name, description, quantity, price, imageBytes);

                Trashes.InsertTrash(newTrash, currentAccountId);

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







        //private void btnKembali_Click(object sender, EventArgs e)
        //{
        //    // Get the trash name and image from the input fields
        //    string trashName = tbNamaSampah.Text;
        //    byte[] trashImage = GetImageBytesFromPictureBox(pbFotoSampah);

        //    // Show the main form and update its display
        //    mainForm.Show();
        //    mainForm.UpdateTrashDisplay(trashImage, trashName);

        //    mainForm.BringToFront();

        //    // Close the current form (TambahSampah)
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
