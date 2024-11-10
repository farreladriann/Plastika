using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class SnapPaymentForm : Form
    {
        public SnapPaymentForm(string snapToken)
        {
            InitializeComponent();
            LoadSnapPage(snapToken);
        }

        private void LoadSnapPage(string snapToken)
        {
            // Load the Snap payment URL with the token
            string snapUrl = $"https://app.sandbox.midtrans.com/snap/v2/vtweb/{snapToken}";
            webBrowser1.Navigate(snapUrl);

            // Attach an event to detect when the user finishes the payment
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Example: Close the form when a specific URL indicates payment completion
            if (e.Url.AbsoluteUri.Contains("payment_complete"))
            {
                MessageBox.Show("Payment completed successfully!");
                this.Close();  // Close the payment form
            }
            else if (e.Url.AbsoluteUri.Contains("payment_failed"))
            {
                MessageBox.Show("Payment failed or was canceled.");
                this.Close();  // Close the payment form
            }
        }
    }

}
