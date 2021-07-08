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
    /// Interaction logic for members_status.xaml
    /// </summary>
    public partial class members_status : Window
    {
        Library Elib;
        public List<member> delayeTopay;
        public List<member> members;
        public List<member> delayeToReturn;
        public members_status()
        {
            InitializeComponent();
            //initialize Elib
            //queri --> delayeTopay = this.Elib.members.where(x=>x.Daysmembershipremaining()<0).select(x=>x.name)
            //queri --> delayeToReturn = this.Elib.books.where(x=>x.owner!=null&&x.timeremaining()<0).select(x=>x.owner.name)
            //queri --> members = Elib.members
            DataContext = this;
        }
    }
}
