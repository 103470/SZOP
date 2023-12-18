using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    internal class User
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string name;

        public string Name {
            get { return name; } 
            set {  name = value; }  
        }

        private char isAdmin;

        public char IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public bool IsAdminBool
        {
            get
            {
                return isAdmin == '1';
            }
        }


    }
}
