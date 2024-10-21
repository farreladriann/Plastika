using Halaman_Utama_Vendor;
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
    /// Interaction logic for HalamanLogin.xaml
    /// </summary>
    public partial class HalamanLogin : Page
    {
        public HalamanLogin()
        {
            InitializeComponent();
        }

        private void btnLoginClick(object sender, RoutedEventArgs e)
        {
            FrameLogin.Content = new MainWindow();
        }
    }
}
