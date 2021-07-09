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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Allemployees.xaml
    /// </summary>
    public partial class Allemployees : Window
    {
        Library lib;
        public ObservableCollection<employe> employees;
        public Allemployees()
        {
            InitializeComponent();
            //initilize lib
            foreach(employe em in lib.employees)
            {
                employees.Add(em);
            }
            DataContext = this;
        }

        private void remove_btn_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
