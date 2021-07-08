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
using System.IO;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for employee.xaml
    /// </summary>
    public partial class employee : Window
    {
        public employee()
        {
            InitializeComponent();
        }

        private void sign_in(object sender, RoutedEventArgs e)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex reemail = new Regex(strRegex, RegexOptions.IgnoreCase);
            if (reemail.IsMatch(usname.Text))
            {
                if (checkinfo(usname.Text, pass.ToString()))
                {
                    employee_panel empl = new employee_panel(usname.Text, pass.ToString());
                    this.Close();
                    empl.Show();

                }
                else
                {
                    MessageBox.Show("wrong info()");
                }
            }
            else
            {
                MessageBox.Show("please input an email adress");
            }




        }
        public bool checkinfo(string usname , string pass)
        {
            //check with data base
            return true;
        }

        private void back(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
    
}
