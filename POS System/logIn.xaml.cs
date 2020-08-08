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
using System.Windows.Shapes;

namespace POS_System
{
    /// <summary>
    /// Interaction logic for logIn.xaml
    /// </summary>
    public partial class logIn : Window
    {
        public logIn()
        {
            //InitializeComponent();
        }

        private void LogIn_btn(object sender, RoutedEventArgs e)
        {
            if (user.Text == global.log_User & pass.Password == global.log_Pass)
            {           
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                this.Close();
            }
            else { notify.Content = "!Please Try Again"; }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            pass.Password = pass.Password + "0";
        }
    }
}
