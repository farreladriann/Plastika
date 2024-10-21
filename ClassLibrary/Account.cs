using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Account
    {
        private int Id{ get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Role { get; set; }

        public int IdAcc
        {
            get { return IdAcc; }
            set { IdAcc = value; }
        }

        public string UsernameAcc
        {
            get { return Username; }
            set { Username = value; }
        }

        public string PasswordAcc
        {
            get { return Password; }
            set { Password = value; }
        }

        public string RoleAcc
        {
            get { return Role; }
            set { Role = value; }
        }



    }
    



}
