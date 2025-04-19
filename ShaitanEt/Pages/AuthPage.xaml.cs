using ShaitanEt.MainBase;
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

namespace ShaitanEt.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new StartPage());
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            App.loggedUser = null;
            if (LoginTb.Text != "" && PassordPb.Password != "")
            {
                foreach (User user in App.sdb.User)
                {
                    if (user.Login == LoginTb.Text && user.Password == PassordPb.Password)
                    {
                        App.loggedUser = user;
                        App.MainFrame.Navigate(new ProfilePage(user));
                    }
                }
                if (App.loggedUser == null) MessageBox.Show("Нету такого человека");
            }
            else
            {
                MessageBox.Show("Пустые поля");
            }
        }
    }
}
