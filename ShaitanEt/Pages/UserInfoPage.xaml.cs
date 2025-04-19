using ShaitanEt.MainBase;
using ShaitanEt.Windows;
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
    /// Логика взаимодействия для UserInfoPage.xaml
    /// </summary>
    public partial class UserInfoPage : Page
    {
        User _user;
        public UserInfoPage(User user)
        {
            InitializeComponent();
            _user = user;
            UserName.Text = user.Name + " " + user.Patronymic;
            Money.Text = "У вас на балансе: " + user.MoneyBank + " .р";
            App.UserInfoPage = this;
        }
        public void PaymentComplete(int money)
        {
            _user.MoneyBank += money;
            Money.Text = "У вас на балансе: " + _user.MoneyBank + " .р";
            App.sdb.SaveChanges();
        }

        private void AddMoney_Click(object sender, RoutedEventArgs e)
        {
            PaymentWindow paymentWindow = new PaymentWindow();
            paymentWindow.ShowDialog();
        }
    }
}
