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
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public static ObservableCollection<managar> MyManager = new ObservableCollection<managar>();
        public static ObservableCollection<employe> MyEmployees = new ObservableCollection<employe>();
        public static ObservableCollection<member> MyMembers = new ObservableCollection<member>();
        public static ObservableCollection<Book> MyBooks = new ObservableCollection<Book>();
        public static ObservableCollection<BorrowedBooks> MyBorrowedBooks = new ObservableCollection<BorrowedBooks>();

        //get information from data base and store it in "THE 5 LISTS"
        public void GetInfoFromDatabase()
        {
            //tmporary objects
            Book tmpBook;
            BorrowedBooks tmpBorrowedBooks;
            employe tmpEmployee;
            managar tmpManager;
            member tmpMember;

            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string command1, command2, command3, command4, command5;

            //take info of all books from database
            command1 = "select * from Books";
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1, con);

            command2 = "select * from BorrowedBooks";
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2, con);

            command3 = "select * from Employees";
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3, con);

            command4 = "select * from Manager";
            SqlDataAdapter adapter4 = new SqlDataAdapter(command4, con);

            command5 = "select * from Members";
            SqlDataAdapter adapter5 = new SqlDataAdapter(command5, con);


            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data1 = new DataTable();
            adapter1.Fill(data1);

            DataTable data2 = new DataTable();
            adapter2.Fill(data2);

            DataTable data3 = new DataTable();
            adapter3.Fill(data3);

            DataTable data4 = new DataTable();
            adapter4.Fill(data4);

            DataTable data5 = new DataTable();
            adapter5.Fill(data5);

            //get info from database, make objects and save to THE 5 LISTS!

            //books
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

            //borrowed books
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

            //employees
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

            //manager
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

            //member
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

            //execution of the command
            SqlCommand com1 = new SqlCommand(command1, con);
            SqlCommand com2 = new SqlCommand(command2, con);
            SqlCommand com3 = new SqlCommand(command3, con);
            SqlCommand com4 = new SqlCommand(command4, con);
            SqlCommand com5 = new SqlCommand(command5, con);

            //execute the command
            com1.BeginExecuteNonQuery();
            com2.BeginExecuteNonQuery();
            com3.BeginExecuteNonQuery();
            com4.BeginExecuteNonQuery();
            com5.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();

        }

        //save changed "THE 5 LISTS" to the database
        public void SaveInfoToDatabase()
        {
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string command1, command2, command3, command4, command5;

            //book
            //command1 = "insert into Employees values('" + name.Trim() + "' ,'" + pass.Trim() + "' )";
            foreach (var x in MyBooks)
            {
                command1 = "insert into Books values('" + x.name + "', '" + x.writer + "', '" + x.count + "', '" + x.publicationNum + "')";
                //execution of the command
                SqlCommand com1 = new SqlCommand(command1, con);
                com1.BeginExecuteNonQuery();
            }

            //borrowed books
            foreach (var x in MyBorrowedBooks)
            {
                command2 = "insert into BorrowedBooks values('" + x.name + "', '" + x.writer + "', '" + x.publicationNum + "', '" + x.memberName + "')";
                //execution of the command
                SqlCommand com2 = new SqlCommand(command2, con);
                com2.BeginExecuteNonQuery();
            }

            //employees
            foreach (var x in MyEmployees)
            {
                command3 = "insert into Employees values('" + x.name + "', '" + x.pass + "', '" + x.email + "', '" + x.phoneNu + "', '" + x.mony + "', '" + x.dateofRecruitment + "')";
                //execution of the command
                SqlCommand com3 = new SqlCommand(command3, con);
                com3.BeginExecuteNonQuery();
            }

            //manager
            foreach (var x in MyManager)
            {
                command4 = "insert into Manager values('" + x.name + "', '" + x.pass + "','" + x.email + "','" + x.mony + "','" + x.phoneNu + "')";
                //execution of the command
                SqlCommand com4 = new SqlCommand(command4, con);
                com4.BeginExecuteNonQuery();
            }

            //member
            foreach (var x in MyMembers)
            {
                command5 = "insert into Members values('" + x.name + "','" + x.pass + "','" + x.email + "'" +
                                                     ",'" + x.phoneNu + "','" + x.mony + "'" +
                                                     ",'" + x.monthlypayment + "','" + x.BorrowedbookNU + "'" +
                                                     ",'" + x.dateofsignup + "','" + x.Renewmembershipdate + "')";
                //execution of the command
                SqlCommand com5 = new SqlCommand(command5, con);
                com5.BeginExecuteNonQuery();
            }

            //close the connection to database
            con.Close();
        }
        public AddBook()
        {
            InitializeComponent();
            GetInfoFromDatabase();
        }

        private void AddBookMethod(string Name, string Writer, int pubNum)
        {
            int previousCount = 0;
            string command, command2;
            bool bookFound = false;

            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            //take info of all books from database
            command = "select * from Books";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);

            //check this book already exists in the library or not
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString() == Name)
                {
                    try
                    {
                        previousCount = int.Parse(data.Rows[i][2].ToString());
                        bookFound = true;
                        break;
                    }
                    catch
                    {

                    }
                }
            }

            if (!bookFound)
            {
                //add new book to database
                command2 = "insert into Books values('" + Name + "' , '" + Writer + "' , '" + 1 + "' , '" + pubNum + "')";
            }
            else
            {
                //increase the number of books in the library by 1
                command2 = "update Books SET count = '" + previousCount + 1 + "' where name = '" + Name + "' ";
            }


            //execution of the commands
            SqlCommand com = new SqlCommand(command, con);
            SqlCommand com2 = new SqlCommand(command2, con);

            //execute the commands
            com.BeginExecuteNonQuery();
            com2.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(validate())
            {
                AddBookMethod(this.nametxt.Text, this.writer.Text, int.Parse(this.Nu.Text));
            }
        }
        public bool validate()
        {
            try
            {
                int n = int.Parse(this.Nu.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("plese enter an intiger number for publition Number  ");
                return false;
            }

        }
        private void back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
    
}
