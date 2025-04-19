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
using ShaitanEt.Pages;
using ShaitanEt.Windows;

namespace ShaitanEt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.MainFrame = MainFrame;
            MainFrame.Navigate(new StartPage());
        }
        
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            SureCloseWindow sureCloseWindow = new SureCloseWindow();
            sureCloseWindow.ShowDialog();
        }

        private void ShowDown_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
