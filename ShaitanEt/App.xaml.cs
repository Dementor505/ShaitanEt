using ShaitanEt.MainBase;
using ShaitanEt.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShaitanEt
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame MainFrame;
        public static Frame SecondFrame;
        public static User loggedUser;
        public static ShaitanEtBaseEntities sdb = new ShaitanEtBaseEntities();
        public static UserInfoPage UserInfoPage;
    }
}
