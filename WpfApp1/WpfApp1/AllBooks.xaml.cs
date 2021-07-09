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
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AllBooks.xaml
    /// </summary>
    public partial class AllBooks : Window
    {
        Library lib;
        public ObservableCollection<Book> books1;
        public AllBooks()
        {
            InitializeComponent();
            //initilize lib
            foreach (Book b in lib.books)
            {
                books1.Add(b);
            }
            DataContext = books1.Where(x => x.borrowed == true);
            this.titletxt.Text = "borrowd books";
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            DataContext = books1;
            this.titletxt.Text = "All books";
        }

        private void borrowd_Click(object sender, RoutedEventArgs e)
        {
            DataContext = books1.Where(x => x.borrowed == true);
            this.titletxt.Text = "borrowd books";
        }

        private void existing_Click(object sender, RoutedEventArgs e)
        {
            DataContext = books1.Where(x => x.borrowed == false);
            this.titletxt.Text = "existing books";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
