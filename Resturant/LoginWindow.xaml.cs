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
using Resturant.DAL;
namespace Resturant
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PasswordText_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            var db = new res_for_sheratonEntities();
            var username = UsernameText.Text;
            var password = PasswordText.Password;
            var user = db.SecUsers.Where(u => u.UserName == username && u.UserPasswd == password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("خطأ في كلمة المرور أو اسم المستخدم");
                UsernameText.Text = "";
                PasswordText.Password = "";
            }
            else
            {
                var mainform = new AdminWindow();
                this.Hide();
                mainform.Show();
            }
        }

        private void UserLogin_Click(object sender, RoutedEventArgs e)
        {
            var db = new res_for_sheratonEntities();
            var username = UsernameText.Text;
            var password = PasswordText.Password;
            var user = db.SecUsers.Where(u => u.UserName == username && u.UserPasswd == password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("خطأ في كلمة المرور أو اسم المستخدم");
                UsernameText.Text = "";
                PasswordText.Password = "";
            }
            else
            {
                var mainform = new MainWindow();
                this.Hide();
                mainform.Show();
            }
        }
    }
}
