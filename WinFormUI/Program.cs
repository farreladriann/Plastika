﻿using AddProdukdanProduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

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
            Env.Load();

            // Pass the main form instance to the TambahSampah form
            Application.Run(new HalamanAwal());
        }
    }
}
