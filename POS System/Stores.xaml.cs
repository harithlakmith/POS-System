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
    /// Interaction logic for Stores.xaml
    /// </summary>
    public partial class Stores : Window
    {
        public Stores()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddItem additm = new AddItem();
            additm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateItem uptitm = new UpdateItem();
            uptitm.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DeleteItem delitm = new DeleteItem();
            delitm.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            itemFind fnditm = new itemFind();
            fnditm.Show();
        }
    }
}
