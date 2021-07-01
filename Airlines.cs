using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Airlines
    {
        private int _ID;
        private string _name;
        private string _airplane;
        private int _seatsAvailable;
        private string _mealAvailable;

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
        public string Airplane
        {
            get { return _airplane; }
            set { _airplane = value; }
        }
        public int SeatsAvailable
        {
            get { return _seatsAvailable; }
            set { _seatsAvailable = value; }
        }
        public string MealAvailable
        {
            get { return _mealAvailable; }
            set { _mealAvailable = value; }
        }
        public Airlines(){}
        public Airlines(int i, string n, string a, int s, string m)
        {
            ID = i;
            Name = n;
            Airplane = a;
            SeatsAvailable = s;
            MealAvailable = m;
        }
    }
}
