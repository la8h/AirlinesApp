using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Logins
    {
        private int _ID;
        private string _username;
        private string _password;
        private int _superUser;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int SuperUser
        {
            get { return _superUser; }
            set { _superUser = value; }
        }
       
        public Logins() { }
        public Logins(int i, string p, int s)
        {
            ID = i;
        //    Username = u;
            Password = p;
            SuperUser = s;
        }

    }
}
