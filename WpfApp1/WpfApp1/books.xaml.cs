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
    /// Interaction logic for books.xaml
    /// </summary>
    public partial class books : Window
    {
        Library lib;
        public ObservableCollection<Book> books1;
        public books()
        {
            InitializeComponent();
            //initilize lib
            foreach(Book b in lib.books)
            {
                books1.Add(b);
            }
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
