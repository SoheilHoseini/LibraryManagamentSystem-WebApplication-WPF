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
    /// Interaction logic for manage_members.xaml
    /// </summary>
    public partial class manage_members : Window
    {
        public manage_members()
        {
            InitializeComponent();
        }

        private void delaydInReturn_btn(object sender, RoutedEventArgs e)
        {
            members_status ms = new members_status();
            ms.Show();
        }

        private void ShowMembers_btn(object sender, RoutedEventArgs e)
        {
            members_status ms = new members_status();
            ms.Show();
        }

        private void one_member_btn(object sender, RoutedEventArgs e)
        {
            one_member_status oms = new one_member_status();
            oms.Show();
        }

        private void DelayedToPay_btn(object sender, RoutedEventArgs e)
        {
            members_status ms = new members_status();
            ms.Show();
        }

        private void back_btn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
