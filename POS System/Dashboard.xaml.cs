using POS_System.ViewModal;
using MaterialDesignThemes.Wpf;
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


namespace POS_System
{
    public class DataItem
    {
        public int code { get; set; }

        
        public string  Name { get; set; }

        public float perprice { get; set; }

        public int qty { get; set; }

        public float price { get; set; }

    }

    public class Tilte { 
    public string title { get; set; }
    }
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
       // List<DataItem> users = new List<DataItem>();
        public Dashboard()
        {
            InitializeComponent();

            global.varqty = 0;
            global.vartot = 0;

           //var users = new List<DataItem>();
            //users.Add(new DataItem() { code = 1, Name = "Frock", perprice =10, qty=2, price=20});
            //users.Add(new DataItem() { code = 2, Name = "Shirt", perprice = 50, qty =1 , price=50});
            //users.Add(new DataItem() { code = 3, Name = "Blouse", perprice = 20 , qty =5, price=100});

            //datagrid.ItemsSource = users;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // DataItem item = new DataItem();
           // item.Column1 = true;
           // item.Column2 = "test";
           // datagrid.Items.Add(item);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users usr = new users();
            usr.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Stores strs = new Stores();
            strs.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Setting sett = new Setting();
            sett.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {


            pay pay = new pay();
            pay.Show();

            this.Close();
        }

       

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int pprice = Convert.ToInt16(eprice.Text);
            int qty = Convert.ToInt16(eqty.Text);
            int price = pprice * qty;

            //var users = new List<DataItem>();
            //users.Add(new DataItem() { code = 00000, Name = "Frock", perprice = pprice, qty = qty, price = price });
            //datagrid.ItemsSource = users;

            var bill = new DataItem()
            { code = 00000, Name = "genaral", perprice = pprice, qty = qty, price = price };
            datagrid.Items.Add(bill);

            global.vartot = global.vartot + price;
            global.varqty = global.varqty + qty;

            int sum = 0;
            int q = 0;
            for (int i = 0; i < datagrid.Items.Count-1 ; ++i)
            {
                sum += (int.Parse((datagrid.Columns[4].GetCellContent(datagrid.Items[i]) as TextBlock).Text));
                q += (int.Parse((datagrid.Columns[3].GetCellContent(datagrid.Items[i]) as TextBlock).Text));
            }
           
            tot.Content = global.vartot;
            ltot.Content = global.vartot;
            qt.Content = global.varqty;

            eprice.Text = "";
            eqty.Text = "1";

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            global.vartot = 0;
            global.varqty = 0;
            datagrid.Items.Clear();
            tot.Content = global.vartot;
            ltot.Content = global.vartot;
            qt.Content = global.varqty;
        }
    }
}
