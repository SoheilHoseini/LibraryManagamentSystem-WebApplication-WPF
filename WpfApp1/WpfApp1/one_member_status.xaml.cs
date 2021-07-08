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
    /// Interaction logic for one_member_status.xaml
    /// </summary>
    public partial class one_member_status : Window
    {

        string nam;
        Library Elib;
        public one_member_status()
        {
            InitializeComponent();
            //initialize Elib
        }

        private void find_person_btn(object sender, RoutedEventArgs e)
        {
            
            this.nam = name.Text;
            this.nametxt.Text = Elib.members.Where(x => x.name == nam).Select(x => x.name).ToString();
            this.monytxt.Text = Elib.members.Where(x => x.name == nam).Select(x => x.mony).ToString();
            this.monthlypaymenttxt.Text = Elib.members.Where(x => x.name == nam).Select(x => x.monthlypayment).ToString();
            this.emailtxt.Text = Elib.members.Where(x => x.name == nam).Select(x => x.email).ToString();
            this.phoneNutxt.Text = Elib.members.Where(x => x.name == nam).Select(x => x.phoneNu).ToString();
            this.Renewmembershipdatetxt.Text = Elib.members.Where(x => x.name == nam).Select(x => x.Renewmembershipdate).ToString();


        }
    }
}
