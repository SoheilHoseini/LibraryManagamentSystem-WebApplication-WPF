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
    /// Interaction logic for employee_panel.xaml
    /// </summary>
    public partial class employee_panel : Window
    {
        Library ELib;
        employe employe1;
        public employee_panel(string email, string Password)
        {
            InitializeComponent();

            //initialize Elib
            //query -->employe1 = library.employes.where(x=>x.email==email&&x.password==password) 
            this.nametxt.Text =  "sth";//witch shoud be given from query --> employe1.name
            
        }


        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void membersStatus_btn(object sender, RoutedEventArgs e)
        {
            manage_members manage = new manage_members();
            manage.Show();

        }
    }
}
