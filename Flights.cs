using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Flights
    {
    //    private List<Airlines> a = new List<Airlines>();
        Airlines al = new Airlines();
        private int _ID;
//        private int _airlineID;
        private string _departureCity;
        private string _destinationCity;
        private string _departureDate;
        private double _flightTime;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /*
        public int AirlineID
        {
            get { return a.ID; }
            set { al.ID = value; }
        }

        */
               public int AirlineID
                {
                    get { return al.ID; }
                    set {al.ID  = value; }
                }
        public string DepartureCity
        {
            get { return _departureCity; }
            set { _departureCity = value; }
        }
        public string DestinationCity
        {
            get { return _destinationCity; }
            set { _destinationCity = value; }
        }
        public string DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }
        public double FlightTime
        {
            get { return _flightTime; }
            set { _flightTime = value; }
        }
        public Flights() { }
        public Flights(int i, int a, string d, string dc, string dd, double f)
        
        {
            ID = i;
            AirlineID = a;
            DepartureCity = d;
            DestinationCity = dc;
            DepartureDate = dd;
            FlightTime = f;
        }
    }
}
