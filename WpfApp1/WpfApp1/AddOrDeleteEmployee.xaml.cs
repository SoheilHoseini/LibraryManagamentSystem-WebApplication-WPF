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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddOrDeleteEmployee.xaml
    /// </summary>
    public partial class AddOrDeleteEmployee : Window
    {
        int v = 0;
        Library lib;
        public AddOrDeleteEmployee()
        {
            InitializeComponent();
            //initilize lib
        }

        private void search(object sender, RoutedEventArgs e)
        {
            try
            {
                employe[] employees = lib.employees.Where(x => x.name == name.Text).ToArray();
                person.Text = employees[0].name;
                this.v = 1;
            }
            catch
            {
                MessageBox.Show("enter name of one employee !");
            }
            
        }
        private void delete(object sender, RoutedEventArgs e)
        {
            if(this.v==1)
            {
                //delete this member
            }
            else
            {
                MessageBox.Show("input employee's name first!");
            }
        }
        public void AddEmpoyee(object sender, RoutedEventArgs e)
        {
            if(validateemail()&& PhoneNuvalidate()&& validateDouble())
            {
                if(passtxt.Text==repasstxt.Text)
                {
                    //add to sql
                }
                else
                {
                    MessageBox.Show("passwords dosn't match!");
                }
               
            }
        }
        public bool validateemail()
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex reemail = new Regex(strRegex, RegexOptions.IgnoreCase);
            if (reemail.IsMatch(emailtxt.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("wrong email!");
                return false;
            }
        }
        public bool PhoneNuvalidate()
        {
            Regex rx = new Regex("^(09)\\d{9}$", RegexOptions.IgnoreCase);
            if(rx.IsMatch(phoneNutxt.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("wrong phone Number!");
                return false;
            }
        }
        public bool validateDouble()
        {
            try
            {
                double n = double.Parse(paymanttxt.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("input a number for paymants!");
                return false;
            }

        }
    }
}
