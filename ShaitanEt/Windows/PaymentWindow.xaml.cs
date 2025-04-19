using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShaitanEt.Windows
{
    /// <summary>
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!IsValidCardNumber(NumberCardTb.Text) ||
                !IsValidCvc(CvcTb.Text) ||
                !int.TryParse(MoneyCountTb.Text, out int amount))
            {
                MessageBox.Show("Проверьте введенные данные");
                return;
            }

            App.UserInfoPage.PaymentComplete(amount);
            Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private bool IsValidCardNumber(string cardNumber)
          => Regex.IsMatch(cardNumber, @"^\d{12}$");

        private bool IsValidCvc(string cvc)
            => Regex.IsMatch(cvc, @"^\d{3}$");
    }
}
