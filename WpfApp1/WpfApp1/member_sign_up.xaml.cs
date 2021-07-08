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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for member_sign_up.xaml
    /// </summary>
    public partial class member_sign_up : Window
    {
        public member_sign_up()
        {
            InitializeComponent();
        }

        private void Sign_up_btn(object sender, RoutedEventArgs e)
        {
            string name = this.nametxt.Text;
            string email = this.emailtxt.Text;
            string imgpath;
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex reemail = new Regex(strRegex, RegexOptions.IgnoreCase);
            if (reemail.IsMatch(this.emailtxt.Text))
            {
                if (validatePhoneNu(this.phonetxt.Text) && passwordtxt.Text == repasswordtxt.Text)
                {

                    string pass = this.passwordtxt.Text;
                    if (male.IsChecked == true)
                    {
                        imgpath = "male.jpg";
                    }
                    else
                    {
                        if (female.IsChecked == true)
                        {
                            imgpath = "female.jpg";
                        }
                        else
                        {
                            imgpath = "male.jpg";
                        }
                    }

                    //add this member to data base
                    user_panel usp = new user_panel(this.nametxt.Text, this.passwordtxt.Text);
                    usp.Show();
                    this.Close();
                }
                else
                {
                    if(!validatePhoneNu(this.phonetxt.Text))
                    {
                        MessageBox.Show("wrong phone number");
                    }
                    if(passwordtxt.Text != repasswordtxt.Text)
                    {
                        MessageBox.Show("please try your password again");
                    }
                    if(nametxt.Text=="")
                    {
                        MessageBox.Show("please enter your name");
                    }
                    if (passwordtxt.Text == "")
                    {
                        MessageBox.Show("please enter your password");
                    }
                }
            }
            else
            {
                MessageBox.Show("please input an email adress");
            }
        }

                
        
        public bool validatePhoneNu(string pNu)
        {
            return true;
        }

        private void back(object sender, RoutedEventArgs e)
        {
            user member = new user();
            member.Show();
            this.Close();
        }
    }
}
