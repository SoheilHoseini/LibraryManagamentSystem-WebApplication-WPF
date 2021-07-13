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
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for user_panel.xaml
    /// </summary>
    public partial class user_panel : Window
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



        string MemUsername, MemPassword;

        public user_panel(string userName , string Password)
        {
            InitializeComponent();

            GetInfoFromDatabase();
            //initilaiz Mlib
            //query --> member1 =library.members.where(x=>x.email==email&&x.password==password) 
            member[] members= MyMembers.Where(x => x.pass == Password).ToArray();
            this.nametxt.Text = members[0].name;
            this.MemUsername = userName;
            this.MemPassword = Password;
        }

        //return to Main Window
        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            books bs = new books();
            bs.Show();
        }

        //return list of the member's borrowed books  *******
        public List<List<string>> BorrowedBooks(string userName)
        {
            List<List<string>> BorrdBooks = new List<List<string>>();
            List<string> tmp;
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take info of all books from database
            command = "select from BorrowedBooks where memberName = '"+ userName +"' ";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                tmp = new List<string>();
                tmp.Add(data.Rows[i][0].ToString());//name
                tmp.Add(data.Rows[i][1].ToString());//writer
                tmp.Add(data.Rows[i][2].ToString());//publication number
                BorrdBooks.Add(tmp);
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();

            return BorrdBooks;
        }

        //returns a string, which consists of all Books *******
        public List<List<string>> AllBooksInfo()
        {
            List<List<string>> AllBooks = new List<List<string>>();
            List<string> tmp;

            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take info of all books from database
            command = "select * from Books";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                tmp = new List<string>();
                tmp.Add(data.Rows[i][0].ToString());//name
                tmp.Add(data.Rows[i][1].ToString());//writer
                tmp.Add(data.Rows[i][3].ToString());//publication number
                AllBooks.Add(tmp);
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();

            return AllBooks;
        }

        //search for a book in database by the book name and return a list of results
        public List<List<string>> SearchByName(string bookName)
        {
            List<List<string>> Result = new List<List<string>>();
            List<string> tmp;

            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take info of all books from database
            command = "select * from Books";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString() == bookName)
                {
                    tmp = new List<string>();
                    tmp.Add(data.Rows[i][0].ToString());//name
                    tmp.Add(data.Rows[i][1].ToString());//writer
                    tmp.Add(data.Rows[i][3].ToString());//publication number
                    Result.Add(tmp);
                }
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();

            return Result;
        }

        //search for a book in database by the writer name and return a list of results
        public List<List<string>> SearchByWriter(string writer)
        {
            List<List<string>> Result = new List<List<string>>();
            List<string> tmp;

            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take info of all books from database
            command = "select * from Books";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == writer)
                {
                    tmp = new List<string>();
                    tmp.Add(data.Rows[i][0].ToString());//name
                    tmp.Add(data.Rows[i][1].ToString());//writer
                    tmp.Add(data.Rows[i][3].ToString());//publication number
                    Result.Add(tmp);
                }
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();


            return Result;
        }

        //search for a book in database by the writer name and book name and return a list of results
        public List<List<string>> SearchByWriterAndBookName(string writer, string bookName)
        {
            List<List<string>> Result = new List<List<string>>();
            List<string> tmp;

            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take info of all books from database
            command = "select * from Books";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == writer && data.Rows[i][0].ToString() == bookName)
                {
                    tmp = new List<string>();
                    tmp.Add(data.Rows[i][0].ToString());//name
                    tmp.Add(data.Rows[i][1].ToString());//writer
                    tmp.Add(data.Rows[i][3].ToString());//publication number
                    Result.Add(tmp);
                }
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();


            return Result;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            member[] members = MyMembers.Where(x => x.pass == MemPassword).ToArray();
            eshterak es = new eshterak(members[0].name);
            es.Show();
        }

        //wallet
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            user_wallet wallet = new user_wallet(MemUsername);
            wallet.Show();
        }

        //personal info
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            user_personal_info up = new user_personal_info(MemUsername);
            up.Show();
        }

        //returns the member's account balance
        public string MemberAccountBalance()
        {
            string tmp = "";
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take info of all books from database
            command = "select * from Members";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString() == MemUsername && data.Rows[i][1].ToString() == MemPassword)
                {
                    tmp = data.Rows[i][4].ToString();
                    break;
                }
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();

            return tmp;
        }


    }
}
