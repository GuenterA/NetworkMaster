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
        string[] type = new string[] { "Device", "Connection",  "Device Model", "Device Type", "Device Manufacturer" };
        public Insert()
        {
            InitializeComponent();
            btnOK.IsEnabled         =  false;
            hide();

            foreach (string item in type)
            {
                cbType.Items.Add(item);
            }
            string[] conType = new string[] { "Fibre Optic", "Copper" };
            foreach (string item in conType)
            {
                cbConType.Items.Add(item);
            }

           
           
            

            //if (string.IsNullOrEmpty(cbType.SelectedItem))
            //{
            //    MessageBox.Show("There is no Item Selected");
            //}
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void hide()
        {
            tbName.Visibility = Visibility.Hidden;
            tbPorts.Visibility = Visibility.Hidden;
            tbLocation.Visibility = Visibility.Hidden;
            tbIP.Visibility = Visibility.Hidden;
            cbConType.Visibility = Visibility.Hidden;
            cbDF.Visibility = Visibility.Hidden;
            cbDT.Visibility = Visibility.Hidden;
            cbPF.Visibility = Visibility.Hidden;
            cbPT.Visibility = Visibility.Hidden;
            labelDevF.Visibility = Visibility.Hidden;
            labelDevT.Visibility = Visibility.Hidden;
            labelIP.Visibility = Visibility.Hidden;
            labelLoc.Visibility = Visibility.Hidden;
            labelName.Visibility = Visibility.Hidden;
            labelPort.Visibility = Visibility.Hidden;
            labelPort.Visibility = Visibility.Hidden;
            labelPortF.Visibility = Visibility.Hidden;
            labelPortT.Visibility = Visibility.Hidden;
            labelType.Visibility = Visibility.Hidden;
            labelMan.Visibility = Visibility.Hidden;
            cbMan.Visibility = Visibility.Hidden;
        }
        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (cbType.SelectedItem == type[0])
            {
                //Device
                this.Title = "Insert a "+type[0];

                hide();

                labelName.Visibility    = Visibility.Visible;
                labelLoc.Visibility     = Visibility.Visible;
                labelIP.Visibility      = Visibility.Visible;
                labelType.Visibility    = Visibility.Visible;
                labelMan.Visibility     = Visibility.Visible;
                tbName.Visibility       = Visibility.Visible;
                tbIP.Visibility         = Visibility.Visible;
                tbLocation.Visibility   = Visibility.Visible;
                cbType.Visibility       = Visibility.Visible;
                cbMan.Visibility        = Visibility.Visible;

            }
            else if (cbType.SelectedItem == type[1])
            {
                //Connection
                this.Title = "Insert a " + type[1];

                hide();

                labelPortF.Visibility   = Visibility.Visible;
                labelPortT.Visibility   = Visibility.Visible;
                labelDevF.Visibility    = Visibility.Visible;
                labelDevT.Visibility    = Visibility.Visible;
                labelType.Visibility    = Visibility.Visible;
                cbDF.Visibility         = Visibility.Visible;
                cbDT.Visibility         = Visibility.Visible;
                cbPF.Visibility         = Visibility.Visible;
                cbPT.Visibility         = Visibility.Visible;
                cbConType.Visibility    = Visibility.Visible;

            }
            else if (cbType.SelectedItem == type[2])
            {
                //Device Model
                this.Title = "Insert a " + type[2];

                hide();

                labelName.Visibility    = Visibility.Visible;
                labelType.Visibility    = Visibility.Visible;
                labelMan.Visibility     = Visibility.Visible;
                labelPort.Visibility    = Visibility.Visible;
                tbName.Visibility = Visibility.Visible;
                cbConType.Visibility = Visibility.Visible;
                cbMan.Visibility = Visibility.Visible;
                tbPorts.Visibility = Visibility.Visible;

            }
            else if (cbType.SelectedItem == type[3])
            {
                //Device Type
                this.Title = "Insert a " + type[3];

                hide();

                labelName.Visibility    = Visibility.Visible;
                tbName.Visibility       = Visibility.Visible;

            }
            else if (cbType.SelectedItem == type[4])
            {
                //Device Device Manufacurer
                this.Title = "Insert a " + type[4];

                hide();
                labelName.Visibility    = Visibility.Visible;
                tbName.Visibility       = Visibility.Visible;
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            //Send the result to the main class
            this.Close();
        }
    }
}
