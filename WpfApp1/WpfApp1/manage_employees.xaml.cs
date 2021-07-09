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
    /// Interaction logic for manage_employees.xaml
    /// </summary>
    public partial class manage_employees : Window
    {
        Library lib;
        public manage_employees()
        {
            InitializeComponent();
            //initilize lib
        }

        private void AddEmployee(object sender, RoutedEventArgs e)
        {
            AddOrDeleteEmployee AODE = new AddOrDeleteEmployee();
            AODE.Show();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            AddOrDeleteEmployee AODE = new AddOrDeleteEmployee();
            AODE.Show();
        }
        private void pay(object sender, RoutedEventArgs e)
        {
            if(passtxt.Password==lib.managar.pass)
            {
                payEmployee();
            }
            else
            {
                MessageBox.Show("your password isn't correct !");
            }
        }
        private void EmployeeShow(object sender, RoutedEventArgs e)
        {
            Allemployees ae = new Allemployees();
            ae.Show();
        }
        private void back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void payEmployee()
        {
            var employeesPayment = lib.employees.Select(x => x.payment);
            double monyTopay = 0;
            foreach(double m in employeesPayment)
            {
                monyTopay += m;
            }
            if(monyTopay>lib.managar.mony)
            {
                foreach(employe Em in lib.employees)
                {
                    Em.mony += Em.payment;
                }
            }
            else
            {
                MessageBox.Show("you do not have enogh mony to pay your employees !");
            }
        }
    }

}
