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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for financial_status.xaml
    /// </summary>
    public partial class financial_status : Window
    {
        Library lib;
        public financial_status()
        {
            InitializeComponent();

            //initilize lib
            amunt.Text= lib.managar.mony.ToString();
        }

        private void increas(object sender, RoutedEventArgs e)
        {
            double n = new double();
            int v = 0;
            try
            {
                n = double.Parse(mony_amunt.Text);
                v = 1;
            }
            catch
            {
                MessageBox.Show("enter only degits");
            }
            if(v==1)
            {
                payment pay = new payment(n);
                pay.Show();
                lib.managar.increasMony();
                amunt.Text = lib.managar.mony.ToString();
            }
;
        }

        private void history(object sender, RoutedEventArgs e)
        {
            pay_history ph = new pay_history();
            ph.Show();
        }
    }
}
