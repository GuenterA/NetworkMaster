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
        public static string ip = "";
        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            string s = textBox_IP1.Text + "." + textBox_IP2.Text + "." + textBox_IP3.Text + "." + textBox_IP4.Text;
            ip = s;
            this.Close();
            
            
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
