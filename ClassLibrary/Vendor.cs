using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Vendor : Account
    {
        private string Name { get; set; }
        private long Phone { get; set; }
        private string Address { get; set; }
        private string Email { get; set; }
        private string Image { get; set; }

        public string NameVendor
        {
            get { return Name; }
            set { Name = value; }
        }

        public long PhoneVendor
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string AddressVendor
        {
            get { return Address; }
            set { Address = value; }
        }

        public string EmailVendor
        {
            get { return Email; }
            set { Email = value; }
        }

        public string ImageVendor
        {
            get { return Image; }
            set { Image = value; }
        }

        public void UpdateVendor(string name, long phone, string address, string email, string image)
        {

        }

        public void UpdateAccountVendor(string username, string password)
        {

        }
    }
    
}
