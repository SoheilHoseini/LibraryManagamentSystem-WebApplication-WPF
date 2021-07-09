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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager mng_sign = new manager();
            mng_sign.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            employee emp_sign = new employee();
            emp_sign.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            user us_sign = new user();
            us_sign.Show();
            this.Close();
        }
    }
    public class managar
    {
        public List<double> payments;
        public string name { get; set; }
        public string pass { get; set; }
        public int mony { get; set; }
        public string email { get; set; }
        public string phoneNu { get; set; }

         /*public managar(string name, string pass, int mony,  string email, string phoneNu)
        {
            this.name = name;
            this.pass = pass;
            this.email = email;
            this.phoneNu = phoneNu;
            
        }*/
        public void AddEmployee() { }
        public void DeletEmployee() { }
        public void pay() { }
        public void ShowMony() { }
        public void increasMony() { }
        public void AddBook() { }
        public void ShowBooks() { }
    }
    public class member
    {
        public string name { get; set; }
        public string pass { get; set; }
        List<Book> Borrowed;
        public int mony { get; set; }
        public int monthlypayment { get; set; }
        public string email { get; set; }
        public string phoneNu { get; set; }
        public DateTime dateofsignup { get; set; }
        public DateTime Renewmembershipdate { get; set; }
        public int BorrowedbookNU { get; set; }
        public ImageSource avatar { get; set; }
        public member(string name, string pass,int mony, int monthlypayment, string email,string phoneNu, DateTime dateofsignup,DateTime Renewmembershipdate,int BorrowedbookNU)
        {
            this.name = name;
            this.pass =pass;
            this.mony=monthlypayment;
            this.monthlypayment=monthlypayment;
            this.email=email;
            this.phoneNu=phoneNu;
            this.dateofsignup=dateofsignup;
            this.Renewmembershipdate=Renewmembershipdate;
            this.BorrowedbookNU=0;
        }
        public void ShowMony() { }
        public void Borrow() { }
        public void ShowAllBooks() { }
        public void ShowBorrowedBooks() { }
        public void returnBook(){}
        public void pay() { }
        public void ChangeInfo() { }
        public void ChangPersonalInfo() { }
        public int Daysmembershipremaining() { return 0; }

    }
    public class employe
    {
        public double payment { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public double mony { get; set; }
        public string email { get; set; }
        public string phoneNu { get; set; }
        public DateTime dateofRecruitment { get; set; }
        public string avatarImgPass { get; set; }
        public employe(string name, string pass, int mony,  string email, string phoneNu, DateTime dateofRecruitment)
        {
            this.name = name;
            this.pass = pass;
            this.email = email;
            this.phoneNu = phoneNu;
            this.dateofRecruitment = dateofRecruitment;
        }

        public void ShowMony() { }
        public void AddBook() { }
        public void ShowAllBooks() { }
        public void ShowBorrowedBooks() { }
        public void ShowExistingbooks() { }
        public void ShowDelaidreturn() { }
        public void ShowDelaidpay() { }
        public void Show1member() { }
        public void ChangPersonalInfo() { }
    }


    public struct Book
    {
        public bool borrowed;
        public member owner;
        public DateTime borrowedDay;
        public string name;
        public string writer;
        public int NU;

        public int timeremaining()
        {
            //calculat time remaining
            return 0;

        }

    }
    public class Library
    {
        public ObservableCollection<Book> books;
        public ObservableCollection<employe> employees;
        public ObservableCollection<member> members;
        public managar managar;
    }
}
