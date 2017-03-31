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

namespace NetworkMaster
{
    /// <summary>
    /// Interaktionslogik für Connect.xaml
    /// </summary>
    public partial class Connect : Window
    {
        public Connect()
        {
            InitializeComponent();
        }
        public static string Server = "";
        public static string DB = "";
        public static string User = "";
        public static string Password = "";
        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            Server = tbServer.Text;
            DB = tbDB.Text;
            User = tbUser.Text;
            Password =  pBPW.Password;

            this.Close();
            
            
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
