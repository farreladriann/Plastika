using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddProdukdanSampah
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Create an instance of the main form
            HalamanUtamaNew mainForm = new HalamanUtamaNew();

            // Pass the main form instance to the TambahSampah form
            Application.Run(new TambahSampah(mainForm));
        }
    }
}
