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
using System.Net;
using System.Net.Sockets;


namespace NetworkMaster
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //<GUI>
        Label NetworkStat = new Label();
        Label ServerIP = new Label();
        bool con;
        byte[] search;
        public MainWindow()
        {
            InitializeComponent();
            GUI();
            StatusBar.VerticalAlignment = VerticalAlignment.Bottom;
            StatusBar.Items.Add(NetworkStat);
            StatusBar.Items.Add(ServerIP);

            SidePanel.HorizontalAlignment = HorizontalAlignment.Left;
            SidePanel.Width = 200;
            SidePanel.Background = Brushes.LightBlue;

        }

public void GUI()
        {
            //Statusbar              
            if (Connect.Server == "")
                NetworkStat.Content = "Not Connected";
            else
                NetworkStat.Content = "Connected";
           
            ServerIP.Content = "Server:" + Connect.Server;
        }

        private void SideExpander_Collapsed(object sender, RoutedEventArgs e)
        {
            SidePanel.Width = 30;
            
        }

        private void SideExpander_Expanded(object sender, RoutedEventArgs e)
        {
            SidePanel.Width = 200;
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Connect win = new Connect();
            win.ShowDialog();
            GUI();        
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Insert win = new Insert();
            win.ShowDialog();
            GUI();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This Software is a Product made by Dominik BARTOSCH and Günter ADENSAM. This Product is under the GPL.");
        }

        //</GUI>
        //<Backend>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Decvices
            con = false;
            //Send devices to server
            con = false;
        }

        private void Con_Click(object sender, RoutedEventArgs e)
        {
            //Connection
            con = true;
            //Send connection to server
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            search = Encoding.ASCII.GetBytes(textBoxSearch.Text);
            SendSearch(search);
        }
        public void SendSearch(byte[] search)
        {
            //Prep for sending
            byte conbin;
            if (con == true)
            {
                conbin = 1;
            }
            else
                conbin = 0;
            search[search.Length + 1] = conbin;
            //Sending


        }
        private void send()
        {
            byte[] a = new byte[]();
            ;
            Socket ClientS = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ClientS.Connect(ip, 4000);
            ClientS.Send(new byte[] { 0, 1, 1, 1, 0, 0, 1, 1 });
            ClientS.Receive(a);
        }

       
            

        //</Backend>

    }
}
