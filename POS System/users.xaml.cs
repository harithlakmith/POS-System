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
    /// Interaction logic for users.xaml
    /// </summary>
    public partial class users : Window
    {
        public users()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCashier csh = new AddCashier();
            csh.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddUser addusr = new AddUser();
            addusr.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DeleteCashier delcash = new DeleteCashier();
            delcash.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DeleteUser delusr = new DeleteUser();
            delusr.Show();
        }
    }
}
