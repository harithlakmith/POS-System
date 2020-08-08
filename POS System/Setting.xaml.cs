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
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pwdold.Password == global.log_Pass)
            {
                global.log_Pass = pwdnew.Password;
                
                notf.Content = "Successfully Updated!";            
            }else { 
                notf.Content = "!Old password is wrong";
                pwdnew.Password = "";
                pwdold.Password = "";
            }
        }
    }
}
