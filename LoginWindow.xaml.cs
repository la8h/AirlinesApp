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

namespace Midterm
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Dictionary<string, Logins> dicLogin = new Dictionary<string, Logins>() 
        { 
        {"John", new Logins(1,"1234",1) },
        {"Jane", new Logins(2,"1235",1) },
        {"Mike", new Logins(3,"1236",0) },
        {"Mia", new Logins(4,"1237",0) },
        {"Jack", new Logins(5,"1238",0) },
        };

     //   dicLogin["John"].ID = 

 //       private string[] users = {"John Smith", "Mary Mike", "George Brown"};
//        private string[] passes = { "pass1", "pass2", "pass3" };
    //    private string user = "John Smith";
    //    private string pass = "pass";
        public LoginWindow()
        {
            InitializeComponent();
        }

        //       string kvp;
        KeyValuePair<string, Logins> kvp;// = new KeyValuePair<string, Logins>() { };
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            foreach (KeyValuePair<string, Logins> kvp in dicLogin)
             //     Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value.Password);
                if ((kvp.Key == tbUsername.Text) && (kvp.Value.Password == pbPass.Password))            
              
                {
                    MainWindow m = new MainWindow();
                    m.Background = Brushes.Azure;
                    m.Title = "Welcome";
                    m.ShowDialog();
                }
               
            }
        //    Logins l = new Logins();
      //    if(dicLogin["John"].Password != tbUsername.Text)
                if(kvp.Key !=  tbUsername.Text || kvp.Value.Password == pbPass.Password)
            {

                MessageBox.Show("Incorrect Username Or password", "Login Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
      /*   
            if (dicLogin["John"] ==  1234) || (passes[k] != pbPass.Password))
            {
                MessageBox.Show("Incorrect Username Or password", "Login Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
     */   




            //      if(dicLogin.Key == "John") { }

            /*        int k = 0;

                    for (int i = 0; i < users.Length; i++)
                    {
                        if ((users[i] == tbUsername.Text) && (passes[i] == pbPass.Password))
                        {
                            MainWindow m = new MainWindow();
                            m.Background = Brushes.Azure;
                            m.Title = "Welcome";
                            m.ShowDialog();
                        }

                        k = i;
                    }*/

            //       for (int i = 0; i < 3; i++)
            //        {
            /*
                     if ((users[k] != tbUsername.Text) || (passes[k] != pbPass.Password))
                        {
                            MessageBox.Show("Incorrect Username Or password", "Login Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
                        }*/

            //        }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
