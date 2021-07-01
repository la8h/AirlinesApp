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
    /// Interaction logic for AirlinesWindow.xaml
    /// </summary>
    public partial class AirlinesWindow : Window
    {
        private  List<Airlines> airlines = new List<Airlines>();
        public AirlinesWindow()
        {
            InitializeComponent();
            rBtnAirplane.IsChecked = true;
            rBtnMeal.IsChecked = true;

            airlines.Add(new Airlines(0,"U.s Airline","Boeing1", 5, "Sushi"));
            airlines.Add(new Airlines(1, "Canada Airline", "Boeing2", 8, "Falaful"));
            airlines.Add(new Airlines(2, "UAE Airline", "Boeing3", 2, "Checken"));
            airlines.Add(new Airlines(3, "China Airline", "Boeing4", 5, "Rice"));
            airlines.Add(new Airlines(4, "Toronto Airline", "Boeing5", 9, "Bread"));

            var names = from al in airlines
                        select al.Name;
           lstAirlines.DataContext = names;
        }

        
        private void btnInsertAirlines_Click(object sender, RoutedEventArgs e)
        {

            if (tbName.Text == "" || tbAirplane.Text == "" || tbSeat.Text == "" || tbMeal.Text == "")
            {
                MessageBox.Show("Text box should be fill", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
               airlines.Add(new Airlines(airlines.Count, tbName.Text, tbAirplane.Text, int.Parse(tbSeat.Text), tbMeal.Text));
                var names = from al in airlines
                            select al.Name;
             lstAirlines.DataContext = names;
            }

            if (rBtnAirplane.IsChecked == true )
            {
                tbAirplane.Text = "Boeing";
              
            }
            else {
                tbAirplane.Text = "Airbus";
               
            }

            if (rBtnMeal.IsChecked == true)
            {
             
                tbMeal.Text = "Checken";
            }
            else
            {
                
                tbMeal.Text = "Bread";
            }

        }

        private void btnUpdateAirlines_Click(object sender, RoutedEventArgs e)
        {
            Airlines a = new Airlines(lstAirlines.SelectedIndex, tbName.Text, tbAirplane.Text, int.Parse(tbSeat.Text), tbMeal.Text);
            airlines[lstAirlines.SelectedIndex] = a;
            var names = from al in airlines
                        select al.Name;
           lstAirlines.DataContext = names;
        }

        private void btnDeleteAirlines_Click(object sender, RoutedEventArgs e)
        {
            airlines.RemoveAt(lstAirlines.SelectedIndex);

            for (int i = 0; i < airlines.Count; i++)
                airlines[i].ID = i;

            var names = from al in airlines
                        select al.Name;
            lstAirlines.DataContext = names;

        }

        private void lstAirlines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstAirlines.SelectedIndex;
            var selectedAirline= from al in airlines
                                   where al.ID == i
                                   select al;
            foreach (var s in selectedAirline)
            {
                tbName.Text = s.Name;
                tbAirplane.Text = s.Airplane;
                tbSeat.Text = s.SeatsAvailable.ToString();
                tbMeal.Text = s.MealAvailable;
               
            }

        }
    }
}
