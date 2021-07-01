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
    /// Interaction logic for CustomersWindow.xaml
    /// </summary>
    public partial class CustomersWindow : Window
    {
        private List<Customer> custs = new List<Customer>();
        private Queue<Customer> people = new Queue<Customer>();


        public CustomersWindow()
        {
            InitializeComponent();

            

            custs.Add(new Customer(0,"John", "123 Street", "john@gmail.com", "123 456 7836"));
            custs.Add(new Customer(1, "Jane", "765 Street", "jane@gmail.com", "123 876 7836"));
            custs.Add(new Customer(2, "Jeorge", "659 Street", "jo@gmail.com", "123 456 9865"));
            custs.Add(new Customer(3, "Mike", "542 Street", "ma@gmail.com", "986 456 7836"));
            custs.Add(new Customer(4, "Robert", "764 Street", "robert@gmail.com", "654 456 7836"));
/*
            people.Enqueue(new Customer(0, "John Smith", "123 street", "john@gmail.com", "123 456 7891"));
            people.Enqueue(new Customer(1, "Mary Mike", "456 street", "mary@gmail.com", "321 456 7891"));
            people.Enqueue(new Customer(2, "George Brown", "789 street", "george@gmail.com", "456 132 7891"));
            people.Enqueue(custs[0]);
*/
            for(int i = 0; i < custs.Count; i++)
                people.Enqueue(custs[i]);

            var names = from cus in people
                        select cus.Name;
           lstCustomers.DataContext = names;
        }
        private void btnInsertCustomers_Click(object sender, RoutedEventArgs e)
        {
            if(tbName.Text == "" || tbAddress.Text == "" || tbEmail.Text == "" || tbPhone.Text == "")
            {
                MessageBox.Show("Text box should be fill", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                people.Enqueue(new Customer(custs.Count, tbName.Text, tbAddress.Text, tbEmail.Text, tbPhone.Text));
       //         custs.Add(new Customer(custs.Count, tbName.Text, tbAddress.Text, tbEmail.Text, tbPhone.Text));
                var names = from cus in people
                            select cus.Name;
                lstCustomers.DataContext = names;
            }

        }

        private void btnUpdateCustomers_Click(object sender, RoutedEventArgs e)
        {
           Customer c = new Customer(lstCustomers.SelectedIndex, tbName.Text, tbAddress.Text, tbEmail.Text, tbPhone.Text);
            custs[lstCustomers.SelectedIndex] = c;
         //   people.Dequeue();
         //   people.Enqueue(c);
            var names = from cus in custs
                        select cus.Name;
            lstCustomers.DataContext = names;
        }

        private void btnDeleteCustomers_Click(object sender, RoutedEventArgs e)
        {
                 custs.RemoveAt(lstCustomers.SelectedIndex);

                  for (int i = 0; i < custs.Count; i++)
                      custs[i].ID = i;
      
         //   people.Dequeue();
            var names = from cus in custs
                        select cus.Name;
            lstCustomers.DataContext = names;
        }

        private void lstCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            var selectedCustomer = from cus in people
                                   where cus.ID == i
                                   select cus;
            foreach (var s in selectedCustomer)
            {
                tbName.Text = s.Name;    
                tbAddress.Text = s.Address;   
                tbEmail.Text = s.Email;   
                tbPhone.Text = s.Phone;                                
            }
        }
    }
}
