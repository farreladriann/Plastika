using Halaman_Utama_Vendor;
using halamanUtamaVendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace halamanUtamaVendor
{
    /// <summary>
    /// Interaction logic for HalamanPemesanan.xaml
    /// </summary>
    public partial class HalamanPemesanan : Page
    {
        public HalamanPemesanan()
        {
            InitializeComponent();
        }

        private void btnPesanClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pemesanan Berhasil!");
        }

        private void btnKembaliClick(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            if (nav != null)
            {
                nav.Navigate(new MainWindow());
            }
        }
    }
}
