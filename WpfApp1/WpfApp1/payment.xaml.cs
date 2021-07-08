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
    /// Interaction logic for payment.xaml
    /// </summary>
    public partial class payment : Window
    {

        public payment(double mony)
        {
            InitializeComponent();
            this.amunt.Text = "$"+mony.ToString();
        }
        //by cancelling the payment process, it will go back to the admin panel
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //return to back menu
            this.Close();
        }

        //when the admin hits "Pay Now" the proccess will end
        private void Pay_Click(object sender, RoutedEventArgs e)
        {

        }

        //closes the payment page
        private void ClosePaymentPage_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
