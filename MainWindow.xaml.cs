using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Queue<Customer> people = new Queue<Customer>();
        private List<Airlines> airlines = new List<Airlines>();
     //   private List<Logins> logins = new List<Logins>();
   //    Logins log = new Logins();
        private Dictionary<string,Logins> dicLogin = new Dictionary<string, Logins>() { {"John", new Logins(1,"1234",1) },
        {"Jane", new Logins(2,"1235",1) },
        {"Mike", new Logins(3,"1236",0) },
        {"Mia", new Logins(4,"1237",0) },
        {"Jack", new Logins(5,"1238",0) },
        };
        
        public MainWindow()
        {
            InitializeComponent();

            people.Enqueue(new Customer(0, "John Smith", "123 street", "john@gmail.com", "123 456 7891"));
            people.Enqueue(new Customer(1, "Mary Mike", "456 street", "mary@gmail.com", "321 456 7891"));
            people.Enqueue(new Customer(2, "George Brown", "789 street", "george@gmail.com", "456 132 7891"));
        }

        private void btnViewCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomersWindow c = new CustomersWindow();
            c.Background = Brushes.Aqua;
            c.Title = "Customers";
            c.ShowDialog();
        }

        private void btnViewFlights_Click(object sender, RoutedEventArgs e)
        {
            FlightsWindow f = new FlightsWindow();
            f.Background = Brushes.Cyan;
            f.Title = "Flights";
            f.ShowDialog();
        }

        private void btnViewAirlines_Click(object sender, RoutedEventArgs e)
        {
            AirlinesWindow a = new AirlinesWindow();
            a.Background = Brushes.Coral;
            a.Title = "Airlines";
            a.ShowDialog();
        }

        private void btnViewPassengers_Click(object sender, RoutedEventArgs e)
        {
            PassengersWindow p = new PassengersWindow();
            p.Background = Brushes.Lavender;
            p.Title = "Passengers";
            p.ShowDialog();
        }
    }
}
