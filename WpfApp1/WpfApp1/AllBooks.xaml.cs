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
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AllBooks.xaml
    /// </summary>
    public partial class AllBooks : Window
    {
        //init "THE 5 LISTS" of all info stored in the database
        public static ObservableCollection<managar> MyManager = new ObservableCollection<managar>();
        public static ObservableCollection<employe> MyEmployees = new ObservableCollection<employe>();
        public static ObservableCollection<member> MyMembers = new ObservableCollection<member>();
        public static ObservableCollection<Book> MyBooks = new ObservableCollection<Book>();
        public static ObservableCollection<BorrowedBooks> MyBorrowedBooks = new ObservableCollection<BorrowedBooks>();

        //get information from data base and store it in "THE 5 LISTS"
        public void GetInfoFromDatabase()
        {
            string command1, command2, command3, command4, command5;

            //tmporary objects
            Book tmpBook;
            BorrowedBooks tmpBorrowedBooks;
            employe tmpEmployee;
            managar tmpManager;
            member tmpMember;

            //////books
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();

            command1 = "select * from Books";
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1, con1);
            DataTable data1 = new DataTable();
            adapter1.Fill(data1);

            for (int i = 0; i < data1.Rows.Count; i++)
            {
                try
                {
                    tmpBook = new Book();
                    tmpBook.name = data1.Rows[i][0].ToString();
                    tmpBook.writer = data1.Rows[i][1].ToString();
                    tmpBook.count = int.Parse(data1.Rows[i][2].ToString());
                    tmpBook.publicationNum = int.Parse(data1.Rows[i][3].ToString());
                    MyBooks.Add(tmpBook);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            SqlCommand com1 = new SqlCommand(command1, con1);
            com1.ExecuteNonQuery();
            con1.Close();



            //////borrowed books
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con2.Open();

            command2 = "select * from BorrowedBooks";
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2, con2);
            DataTable data2 = new DataTable();
            adapter2.Fill(data2);

            for (int i = 0; i < data2.Rows.Count; i++)
            {
                try
                {
                    tmpBorrowedBooks = new BorrowedBooks();
                    tmpBorrowedBooks.name = data2.Rows[i][0].ToString();
                    tmpBorrowedBooks.writer = data2.Rows[i][1].ToString();
                    tmpBorrowedBooks.publicationNum = int.Parse(data2.Rows[i][2].ToString());
                    tmpBorrowedBooks.memberName = data2.Rows[i][3].ToString();
                    MyBorrowedBooks.Add(tmpBorrowedBooks);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            SqlCommand com2 = new SqlCommand(command2, con2);
            com2.ExecuteNonQuery();
            con2.Close();



            //////employees
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con3.Open();

            command3 = "select * from Employees";
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3, con3);
            DataTable data3 = new DataTable();
            adapter3.Fill(data3);

            for (int i = 0; i < data3.Rows.Count; i++)
            {
                try
                {
                    tmpEmployee = new employe();
                    tmpEmployee.name = data3.Rows[i][0].ToString();
                    tmpEmployee.pass = data3.Rows[i][1].ToString();
                    tmpEmployee.email = data3.Rows[i][2].ToString();
                    tmpEmployee.phoneNu = data3.Rows[i][3].ToString();
                    tmpEmployee.mony = float.Parse(data3.Rows[i][4].ToString());
                    tmpEmployee.dateofRecruitment = DateTime.Parse(data3.Rows[i][5].ToString());
                    MyEmployees.Add(tmpEmployee);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            SqlCommand com3 = new SqlCommand(command3, con3);
            com3.ExecuteNonQuery();
            con3.Close();



            //////manager
            SqlConnection con4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con4.Open();

            command4 = "select * from Manager";
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4, con4);
            DataTable data4 = new DataTable();
            adapter4.Fill(data4);

            for (int i = 0; i < data4.Rows.Count; i++)
            {
                try
                {
                    tmpManager = new managar();
                    tmpManager.name = data4.Rows[i][0].ToString();
                    tmpManager.pass = data4.Rows[i][1].ToString();
                    tmpManager.email = data4.Rows[i][2].ToString();
                    tmpManager.mony = float.Parse(data4.Rows[i][3].ToString());
                    tmpManager.phoneNu = data4.Rows[i][4].ToString();
                    MyManager.Add(tmpManager);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            SqlCommand com4 = new SqlCommand(command4, con4);
            com4.ExecuteNonQuery();
            con4.Close();



            //////member
            SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con5.Open();

            command5 = "select * from Members";
            SqlDataAdapter adapter5 = new SqlDataAdapter(command5, con5);
            DataTable data5 = new DataTable();
            adapter5.Fill(data5);

            for (int i = 0; i < data5.Rows.Count; i++)
            {
                try
                {
                    tmpMember = new member();
                    tmpMember.name = data5.Rows[i][0].ToString();
                    tmpMember.pass = data5.Rows[i][1].ToString();
                    tmpMember.email = data5.Rows[i][2].ToString();
                    tmpMember.phoneNu = data5.Rows[i][3].ToString();
                    tmpMember.mony = float.Parse(data5.Rows[i][4].ToString());
                    tmpMember.monthlypayment = float.Parse(data5.Rows[i][5].ToString());
                    tmpMember.BorrowedbookNU = int.Parse(data5.Rows[i][6].ToString());
                    tmpMember.dateofsignup = DateTime.Parse(data5.Rows[i][7].ToString());
                    tmpMember.Renewmembershipdate = DateTime.Parse(data5.Rows[i][8].ToString());
                    MyMembers.Add(tmpMember);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            SqlCommand com5 = new SqlCommand(command5, con5);
            com5.ExecuteNonQuery();
            con5.Close();
        }

        //save the FIRST info to the database
        public void SaveInfoToDatabase()
        {
            string command1, command2, command3, command4, command5;
            //update info
            //command = "update Table1 SET name = '" + "ahmad" + "', age = '" + 15 + "' , employed = '" + true + "' where name = '" + a + "' ";

            //book
            foreach (var x in MyBooks)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con1.Open();

                command1 = "insert into Books values('" + x.name + "', '" + x.writer + "', '" + x.count + "', '" + x.publicationNum + "')";
                //execution of the command
                SqlCommand com1 = new SqlCommand(command1, con1);
                com1.ExecuteNonQuery();
                con1.Close();
            }

            //borrowed books
            foreach (var x in MyBorrowedBooks)
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con2.Open();

                command2 = "insert into BorrowedBooks values('" + x.name + "', '" + x.writer + "', '" + x.publicationNum + "', '" + x.memberName + "')";
                //execution of the command
                SqlCommand com2 = new SqlCommand(command2, con2);
                com2.ExecuteNonQuery();
                con2.Close();
            }

            //employees
            foreach (var x in MyEmployees)
            {
                SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con3.Open();

                command3 = "insert into Employees values('" + x.name + "', '" + x.pass + "', '" + x.email + "', '" + x.phoneNu + "', '" + x.mony + "', '" + x.dateofRecruitment + "')";
                //execution of the command
                SqlCommand com3 = new SqlCommand(command3, con3);
                com3.ExecuteNonQuery();

                con3.Close();
            }

            //manager
            foreach (var x in MyManager)
            {
                SqlConnection con4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con4.Open();

                command4 = "insert into Manager values('" + x.name + "', '" + x.pass + "','" + x.email + "','" + x.mony + "','" + x.phoneNu + "')";
                //execution of the command
                SqlCommand com4 = new SqlCommand(command4, con4);
                com4.ExecuteNonQuery();

                con4.Close();
            }

            //member
            foreach (var x in MyMembers)
            {

                SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con5.Open();

                command5 = "insert into Members values('" + x.name + "','" + x.pass + "','" + x.email + "','" + x.phoneNu + "','" + x.mony + "','" + x.monthlypayment + "','" + x.BorrowedbookNU + "' ,'" + x.dateofsignup + "','" + x.Renewmembershipdate + "')";
                //execution of the command
                SqlCommand com5 = new SqlCommand(command5, con5);
                com5.ExecuteNonQuery();
                con5.Close();
            }
        }

        //update the changes of "THE 5 LISTS" to the database
        public void UpdateInfoOfDatabase()
        {
            string command1, command2, command3, command4, command5;
            //update info
            //command = "update Table1 SET name = '" + "ahmad" + "', age = '" + 15 + "' , employed = '" + true + "' where name = '" + a + "' ";

            //book
            foreach (var x in MyBooks)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con1.Open();
                command1 = "update Books SET writer = '" + x.writer + "', count = '" + x.count + "', publicationNum = '" + x.publicationNum + "' where name = '" + x.name + "' ";
                //command1 = "insert into Books values('" + x.name + "', '" + x.writer + "', '" + x.count + "', '" + x.publicationNum + "')";

                //execution of the command
                SqlCommand com1 = new SqlCommand(command1, con1);
                com1.ExecuteNonQuery();
                con1.Close();
            }

            //borrowed books
            foreach (var x in MyBorrowedBooks)
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con2.Open();
                command2 = "update BorrowedBooks SET writer = '" + x.writer + "', memberName = '" + x.memberName + "', publicationNum = '" + x.publicationNum + "' where name = '" + x.name + "' ";
                //command2 = "insert into BorrowedBooks values('" + x.name + "', '" + x.writer + "', '" + x.publicationNum + "', '" + x.memberName + "')";

                //execution of the command
                SqlCommand com2 = new SqlCommand(command2, con2);
                com2.ExecuteNonQuery();
                con2.Close();
            }

            //employees
            foreach (var x in MyEmployees)
            {
                SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con3.Open();
                command3 = "update Employees SET password = '" + x.pass + "', email = '" + x.email + "', phonenum = '" + x.phoneNu + "', money = '" + x.mony + "', dateOfRecruitment = '" + x.dateofRecruitment + "' where name = '" + x.name + "' ";
                //command3 = "insert into Employees values('" + x.name + "', '" + x.pass + "', '" + x.email + "', '" + x.phoneNu + "', '" + x.mony + "', '" + x.dateofRecruitment + "')";

                //execution of the command
                SqlCommand com3 = new SqlCommand(command3, con3);
                com3.ExecuteNonQuery();

                con3.Close();
            }

            //manager
            foreach (var x in MyManager)
            {
                SqlConnection con4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con4.Open();
                command4 = "update Manager SET password = '" + x.pass + "', email = '" + x.email + "', money = '" + x.mony + "', phoneNum = '" + x.phoneNu + "' where name = '" + x.name + "' ";
                //command4 = "insert into Manager values('" + x.name + "', '" + x.pass + "','" + x.email + "','" + x.mony + "','" + x.phoneNu + "')";

                //execution of the command
                SqlCommand com4 = new SqlCommand(command4, con4);
                com4.ExecuteNonQuery();

                con4.Close();
            }

            //member
            foreach (var x in MyMembers)
            {

                SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
                con5.Open();
                command5 = "update Members SET password = '" + x.pass + "', email = '" + x.email + "', phoneNum = '" + x.phoneNu + "', money = '" + x.mony + "', monthlyPayment = '" + x.monthlypayment + "', BorrowedBookNum = '" + x.BorrowedbookNU + "', dateOfSignUp = '" + x.dateofsignup + "', RenewMemberShipDate = '" + x.Renewmembershipdate + "' where memberName = '" + x.name + "' ";
                //command5 = "insert into Members values('" + x.name + "','" + x.pass + "','" + x.email + "','" + x.phoneNu + "','" + x.mony + "','" + x.monthlypayment + "','" + x.BorrowedbookNU + "' ,'" + x.dateofsignup + "','" + x.Renewmembershipdate + "')";

                //execution of the command
                SqlCommand com5 = new SqlCommand(command5, con5);
                com5.ExecuteNonQuery();
                con5.Close();
            }
        }


        Library lib;
        public ObservableCollection<Book> books1;
        public AllBooks()
        {
            InitializeComponent();
            GetInfoFromDatabase();
            //initilize lib
            foreach (Book b in lib.books)
            {
                books1.Add(b);
            }
            DataContext = MyBorrowedBooks;//***************
            this.titletxt.Text = "borrowd books";
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            DataContext = MyBooks;
            this.titletxt.Text = "All books";
        }

        private void borrowd_Click(object sender, RoutedEventArgs e)
        {
            DataContext = MyBorrowedBooks;//***************
            this.titletxt.Text = "borrowd books";
        }

        private void existing_Click(object sender, RoutedEventArgs e)
        {
            DataContext = MyBooks.Where(x => x.borrowed == false);//***************
            this.titletxt.Text = "existing books";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
