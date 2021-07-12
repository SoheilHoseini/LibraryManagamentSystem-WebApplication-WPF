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
    /// Interaction logic for manage_employees.xaml
    /// </summary>
    public partial class manage_employees : Window
    {
        //init "THE 5 LISTS" of all info stored in the database
        public static ObservableCollection<managar> MyManager = new ObservableCollection<managar>();
        public static ObservableCollection<employe> MyEmployees = new ObservableCollection<employe>();
        public static ObservableCollection<member> MyMembers = new ObservableCollection<member>();
        public static ObservableCollection<Book> MyBooks = new ObservableCollection<Book>();
        public static ObservableCollection<BorrowedBooks> MyBorrowedBooks = new ObservableCollection<BorrowedBooks>();

        //get information from data base and store it in "THE 5 LISTS"
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


        public manage_employees()
        {
            InitializeComponent();

            GetInfoFromDatabase();
        }

        //
        private void AddEmployee(object sender, RoutedEventArgs e)
        {
            AddOrDeleteEmployee AODE = new AddOrDeleteEmployee();
            AODE.Show();
        }

        //
        private void Delete(object sender, RoutedEventArgs e)
        {
            AddOrDeleteEmployee AODE = new AddOrDeleteEmployee();
            AODE.Show();
        }

        //
        private void pay(object sender, RoutedEventArgs e)
        {
            if(passtxt.Password == MyManager[0].pass)
            {
                payEmployee();
                MessageBox.Show("You paid your employees bro!");
            }
            else
            {
                MessageBox.Show("Your password isn't correct !");
            }
        }

        //
        private void EmployeeShow(object sender, RoutedEventArgs e)
        {
            Allemployees ae = new Allemployees();
            ae.Show();
        }

        //return to the Manager Panel
        private void back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //
        public void payEmployee()
        {
            float monyTopay = 1000 * MyEmployees.Count;

            
            if (monyTopay < MyManager[0].mony)
            {
                foreach(employe Em in MyEmployees)
                {
                    Em.mony += 1000;
                }
                MyManager[0].mony -= monyTopay;
                UpdateInfoOfDatabase();
            }
            else
            {
                MessageBox.Show("You do not have enough money to pay the employees!");
            }
        }

        //check the intered password with data base before paying the employees
        public bool CheckManagerPassword(string pass)
        {
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command, savedPass;

            //take all info of the maneger from database
            command = "select * from Manager";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);//we can't get the info from adapter, so we just pour the info in data to manipulate
            savedPass = data.Rows[0][1].ToString();

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery(); 

            //close the connection to database
            con.Close();
            if (savedPass == pass)
                return true;

            else
                return false;
        }

        //returns a string, which consists of information of all employees *******
        public string EmployeesInfo()
        {
            string tmp = "";
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //take all info of the maneger from database
            command = "select * from Employees";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);

            //we can't get the info from adapter, so we just pour the info in data to manipulate
            DataTable data = new DataTable();
            adapter.Fill(data);
            
            for(int i = 0; i < data.Rows.Count; i++)
            {
                tmp += data.Rows[i][0].ToString() + " " + data.Rows[i][3].ToString() + " " + data.Rows[i][5].ToString() + "\n";
            }

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();

            return tmp;
        }

        //takes info of an employee as input and save it to database
        public void AddEmployeeToDatabase(string name, string pass, string email, string phNum, int money, DateTime dt)
        {
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            command = "insert into Employees values('"+ name.Trim() +"' ,'"+ pass.Trim() +"' ,'"+ email.Trim() +"' ,'"+ phNum.Trim() +"' ,'"+ money +"' ,'"+ dt +"' )";

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();
        }

        //takes name and password of an employee as input and remove its record from database
        public void RemoveRecordFromDB(string Name, string pass)
        {
            //open the connection to database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahand\Desktop\University\AP\WPF Project\LibraryDataBaseCenter.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string command;

            //delete a row. (or can save info of a table somewhere, delete it , modify the saved info and insert it again
            command = "delete from Employees where name = '" + Name + "' AND password = '"+ pass +"' ";

            //execution of the command
            SqlCommand com = new SqlCommand(command, con);

            //execute the command
            com.BeginExecuteNonQuery();

            //close the connection to database
            con.Close();
        }


    }

}
