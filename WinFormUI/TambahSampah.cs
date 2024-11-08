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
        public TambahSampah(HalamanUtamaNew halamanutama)
        {
            InitializeComponent();
            mainForm = halamanutama;


        }
        
        //private NpgsqlConnection conn;
        //string connstring = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        //public static NpgsqlCommand cmd;
        //private string sql = null;
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    conn = new NpgsqlConnection(connstring);

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
                // Menmabhakan trashes instans
                string name = tbNamaSampah.Text;
                string description = tbDeskripsiSampah.Text;
                int quantity = int.Parse(tbKuantitasSampah.Text);
                long price = long.Parse(tbHargaSampah.Text);
                byte[] imageBytes = null;

                // Convert image dari PictureBox menjadi byte array
                if (pbFotoSampah.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFotoSampah.Image.Save(ms, pbFotoSampah.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                // Membuat object dari trashes
                Trashes newTrash = new Trashes(name, description, quantity, price, imageBytes);

                // open koneksi database
                //    conn.Open();
                //    sql = @"
                //            begin;
                //                insert into pub_plastika.""Trashes""
                //                (
                //                    trash_name, 
                //                    description, 
                //                    quantity, 
                //                    price, 
                //                    images_trashes
                //                )
                //                values
                //                (
                //                    _trash_name,
                //                    _description,
                //                    _quantity,
                //                    _price,
                //                    _trash_image
                //                );
                //                if found then
                //                    return 1;
                //                else
                //                    return 0;
                //                end if;
                //            end;
                //            ";
                //    cmd = new NpgsqlCommand(sql, conn);

                //    // Mengugnakan properti dari trashes untuk mengisi parameter
                //    cmd.Parameters.AddWithValue("_trash_name", newItem.Trash_Name);
                //    cmd.Parameters.AddWithValue("_description", newItem.Description);
                //    cmd.Parameters.AddWithValue("_quantity", newItem.Quantity);
                //    cmd.Parameters.AddWithValue("_price", newItem.Price);

                //    // mengatur parameter image jika null maka akan diisi dengan DBNull.Value agar tidak error
                //    var imageParameter = new NpgsqlParameter("_trash_image", NpgsqlTypes.NpgsqlDbType.Bytea);
                //    if (newItem.Trash_Image != null)
                //    {
                //        imageParameter.Value = newItem.Trash_Image;
                //    }
                //    else
                //    {
                //        imageParameter.Value = DBNull.Value;
                //    }
                //    cmd.Parameters.Add(imageParameter);

                //    // Execute the command and check the result
                //    if ((int)cmd.ExecuteScalar() == 1)
                //    {
                //        MessageBox.Show("Data Sampah Berhasil Ditambahkan");
                //    }
                //    conn.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
                //}
                //finally
                //{
                //    // Ensure the connection is closed even if an error occurs
                //    if (conn.State == ConnectionState.Open)
                //    {
                //        conn.Close();
                //    }
                //}
                DatabaseHelper.InsertTrash(newTrash);
                MessageBox.Show("Data berhasil ditambahkan!");
                // Show success message

            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!!");
            }

            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide(); // Kembali ke halaman utama
            HalamanUtamaNew halamanUtama = new HalamanUtamaNew();
            halamanUtama.Show();
        }



        //    private void btnKembali_Click(object sender, EventArgs e)
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
