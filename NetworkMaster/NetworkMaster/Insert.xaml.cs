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
    /// Interaktionslogik für Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        string[] type = new string[] { "Connection", "Device", "Device Model", "Device Type", "Device Mnufacturer" };
        public Insert()
        {
            InitializeComponent();
            btnOK.IsEnabled = false;
            
            foreach (string item in type)
            {
                cbType.Items.Add(item);
            }
            string[] conType = new string[] { "Fibre Optic", "Copper" };
            foreach (string item in conType)
            {
                cbConType.Items.Add(item);
            }

           
           
            

            //if (string.IsNullOrEmpty(cbType.Text))
            //{
            //    MessageBox.Show("There is no Item Selected");
            //}
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbType.Text == type[0])
            {
                throw new NotImplementedException();
            }
            else if (cbType.Text == type[1])
            {
                tbName.Visibility = Visibility.Hidden;
            }
            else if (cbType.Text == type[2])
            {
                this.Title = "Insert a Device";
            }
            else if (cbType.Text == type[3])
            {
                this.Title = "Insert a Device";
            }
            else if (cbType.Text == type[4])
            {
            }
        }
    }
}
