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
using PR_22._101_Bakhturov_authorization.Models;
using PR_22._101_Bakhturov_authorization;

namespace PR_22._101_Bakhturov_authorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtbLogin.Text.Trim();
            string password = pswbPassword.Text.Trim();
            KREntities db = Helper.GetContext();
            var user = db.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Добро пожаловать! Ваша роль:" + user.Employees.Role);

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void txtbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void pswbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
