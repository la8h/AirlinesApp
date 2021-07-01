using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;


namespace Midterm
{
    /// <summary>
    /// Interaction logic for FlightsWindow.xaml
    /// </summary>
    public partial class FlightsWindow : Window
    {
        private Stack<Flights> flight = new Stack<Flights>();
        private List<Flights> FlightList = new List<Flights>();
              private List<Airlines> airlines = new List<Airlines>();

        //    private AirlinesWindow alw= new AirlinesWindow();
        private Airlines a = new Airlines();
        public FlightsWindow()
        {
            InitializeComponent();
            
            FlightList.Add(new Flights(0, a.ID, "New York", "Toronto", "11-11-2021", 7.7));
            FlightList.Add(new Flights(1, a.ID, "Toronto", "New York", "12-11-2021", 7.7));
            FlightList.Add(new Flights(2, a.ID, "New York", "London", "13-11-2021", 17.7));
            FlightList.Add(new Flights(3, a.ID, "London", "Toronto", "14-11-2021", 9.7));
            FlightList.Add(new Flights(4, a.ID, "Victoria", "Victoria", "15-11-2021", 10.7));
            //airlines[3].ID


            for (int i = 0; i < FlightList.Count; i++)
                flight.Push(FlightList[i]);

            var cites = from fl in flight
                            //    orderby fl descending
                            //           select fl.DepartureCity;
                        select fl.AirlineID;

            lstFlights.DataContext = cites;

            //    e.Add(cities[0]);

        }


        private void btnInsertFlights_Click(object sender, RoutedEventArgs e)
        {
            if (tbDepCity.Text == "" || tbDisCity.Text == "" || tbDepDate.Text == "" || tbFlightTime.Text == "")
            {
                MessageBox.Show("Text box should be fill", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                flight.Push(new Flights(flight.Count, a.ID, tbDepCity.Text, tbDisCity.Text, tbDepDate.Text, double.Parse(tbFlightTime.Text)));
                var cites = from fl in flight
                            select fl.DepartureCity;
                lstFlights.DataContext = cites;

            }
        }

        private void btnUpdateFlights_Click(object sender, RoutedEventArgs e)
        {
            Flights f = new Flights(lstFlights.SelectedIndex, a.ID, tbDepCity.Text, tbDisCity.Text, tbDepDate.Text, double.Parse(tbFlightTime.Text));

            FlightList[lstFlights.SelectedIndex] = f;
            //    flight.Clear();
            //   flight.Pop();
            //        flight.Push(f);
            /*
                        for (int i = lstFlights.SelectedIndex + 1; i < flight.Count - 1; i++)
                        {
                            flight.Push(new Flights(i, flight.Count, tbDepCity.Text, tbDisCity.Text, tbDepDate.Text, double.Parse(tbFlightTime.Text)));

                        }
            */
            var cites = from fl in FlightList
                        select fl.DepartureCity;
            lstFlights.DataContext = cites;

        }

        private void btnDeleteFlights_Click(object sender, RoutedEventArgs e)
        {

            FlightList.RemoveAt(lstFlights.SelectedIndex);

            for (int i = 0; i < FlightList.Count; i++)
                FlightList[i].ID = i;

            //   people.Dequeue();
            var names = from fl in FlightList
                        select fl.DepartureCity;
            lstFlights.DataContext = names;

            //       int selectedIndex = lstFlights.SelectedIndex;
            //       e.RemoveAt(selectedIndex);
            /*
                        flight.Pop();
                        var cites = from fl in flight
                                    select fl.DepartureCity;
                        lstFlights.DataContext = cites; */
        }
        private void lstFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstFlights.SelectedIndex;
            var selectedFlight = from fl in flight
                                 where fl.ID == i
                                 select fl;
            foreach (var s in selectedFlight)
            {
                tbDepCity.Text = s.DepartureCity;
                tbDisCity.Text = s.DestinationCity;
                tbDepDate.Text = s.DepartureDate;
                //     tbFlightTime.Text = s.DepartureDate;
                tbFlightTime.Text = s.FlightTime.ToString();
            }

        }
        //AirlineID
        private void lstForeignK_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstForeignK.SelectedIndex;
            var selectedFK = from lk in airlines
                             where lk.ID == i
                             select lk;
            foreach (var s in selectedFK)
            {
               /*  tbName.Text = s.Name;
                   tbAirplane.Text = s.Airplane;
                   tbSeat.Text = s.SeatsAvailable.ToString();
                   tbMeal.Text = s.MealAvailable;
         */
            }
        }
    }
}
