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
    /// Interaction logic for manager_panel.xaml
    /// </summary>
    public partial class manager_panel : Window
    {
        managar manager1;
        Library lib;

        public manager_panel(string email , string password)
        {
            InitializeComponent();
            //initialize Lib
            //query -->managar1= library.manager
            this.nametxt.Text = "sth";//witch shoud be given from query --> manager1.name

        }


        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void financial(object sender, RoutedEventArgs e)
        {
            financial_status fs = new financial_status();
            fs.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manage_employees me = new manage_employees();
            me.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AllBooks Ab = new AllBooks();
            Ab.Show();
        }
    }
}
