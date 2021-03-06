using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Customer
    {
        private int _ID;
        private string _name;
        private string _address;
        private string _email;
        private string _phone;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public Customer() { }
        public Customer(int i, string n, string a, string e, string p)
        {
            ID = i;
            Name = n;
            Address = a;
            Email = e;
            Phone = p;
        }
    }
}
