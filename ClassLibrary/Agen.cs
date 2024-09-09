using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Agen : Account
    {
       
        private string Name { get; set; }
        private long Phone { get; set; }
        private string Address { get; set; }
        private string Email { get; set; }
        private string Image { get; set; }

        public string NameAgen
        {
            get { return Name; }
            set { Name = value; }
        }

        public long PhoneAgen
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string AddressAgen
        {
            get { return Address; }
            set { Address = value; }
        }

        public string EmailAgen
        {
            get { return Email; }
            set { Email = value; }
        }

        public string ImageAgen
        {
            get { return Image; }
            set { Image = value; }
        }

        public void UpdateAgen(string name, long phone, string address, string email, string image)
        {
            
        }

        public void UpdateAccountAgen(string username, string password)
        {

        }   
    }


}
