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
    /// Interaction logic for pay.xaml
    /// </summary>
    public partial class pay : Window
    {
        public pay()
        {
            InitializeComponent();
            total.Content = global.vartot;
            start.Visibility = System.Windows.Visibility.Visible;
            cash.Visibility = System.Windows.Visibility.Hidden;
            cards.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.Visibility = System.Windows.Visibility.Hidden;
            cash.Visibility = System.Windows.Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            start.Visibility = System.Windows.Visibility.Hidden;
            cards.Visibility = System.Windows.Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
            Dashboard dsh = new Dashboard();
           
            dsh.Show();
            dsh.datagrid.Items.Clear();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Dashboard dsh = new Dashboard();
            
            dsh.Show();
            dsh.datagrid.Items.Clear();
            this.Close();
        }

       /* private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                App.Current.Windows[intCounter].Close();
        }*/

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int cash = Convert.ToInt16(csh.Text);
            int tot = Convert.ToInt16(total.Content);
            int balnce = cash - tot;
            bal.Text = Convert.ToString(balnce);
        }
    }
}
