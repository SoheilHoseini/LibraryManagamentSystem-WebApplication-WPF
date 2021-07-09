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
    /// Interaction logic for user_panel.xaml
    /// </summary>
    public partial class user_panel : Window
    {

        Library Mlib;
        member member1;


        public user_panel(string email , string Password)
        {
            InitializeComponent();
            //initilaiz Mlib
            //query --> member1 =library.members.where(x=>x.email==email&&x.password==password) 
            this.nametxt.Text = "sth";//witch shoud be given from query --> member1.name

        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            books bs = new books();
            bs.Show();
        }
    }
}
