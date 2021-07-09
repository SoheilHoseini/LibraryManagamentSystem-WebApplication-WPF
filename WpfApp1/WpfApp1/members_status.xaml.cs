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
    /// Interaction logic for members_status.xaml
    /// </summary>
    public partial class members_status : Window
    {
        Library Elib;
        public ObservableCollection<member> delayeTopay;
        public ObservableCollection<member> members;
        public ObservableCollection<member> delayeToReturn;
        public members_status()
        {
            InitializeComponent();
            //initialize Elib
            foreach(member m in this.Elib.members.Where(x => x.Daysmembershipremaining() < 0))
            {
                delayeTopay.Add(m);
            }
            foreach(member m in this.Elib.books.Where(x => x.owner != null && x.timeremaining() < 0).Select(x => x.owner))
            {
                delayeToReturn.Add(m);
            }
            foreach(member m in Elib.members)
            {
                members.Add(m);
            }
            DataContext = this;
        }
    }
}
