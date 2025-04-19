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
using ShaitanEt.MainBase;

namespace ShaitanEt.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage(User user)
        {
            InitializeComponent();
            App.SecondFrame = SecondFrame;
            SecondFrame.Navigate(new UserInfoPage(user));
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            App.SecondFrame.Navigate(new UserInfoPage(App.loggedUser));
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            App.SecondFrame.Navigate(new ProductListPage());
        }
    }
}
