using ShaitanEt.MainBase;
using ShaitanEt.MainControls;
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
using System.Xaml;

namespace ShaitanEt.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    ///  private int _currentPage = 1;
    public partial class ProductListPage : Page
    {
    private int _currentPage = 1;
    private const int ItemsPerPage = 6;
    private List<Product> _allProducts = new List<Product>();
        public ProductListPage()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            _allProducts = App.sdb.Product.ToList();

            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            ProductPanel.Children.Clear();

            var productForPage = _allProducts
                .Skip((_currentPage - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                .ToList();

            List<BitmapImage> images = new List<BitmapImage>() {new BitmapImage(new Uri("\\Resources\\Pr1.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr10.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr11.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr12.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr13.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr14.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr1.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr2.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr3.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr4.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr5.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr6.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr7.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr8.jpg",UriKind.Relative)),
                new BitmapImage(new Uri("\\Resources\\Pr9.jpg",UriKind.Relative)),
            };
            int count = 0;
            foreach (Product product in productForPage)
            {
                if (images[count] != null) ProductPanel.Children.Add(new ProductControl(product, images[count]));
                count++;
            }

            int totalProductPages = (int)Math.Ceiling((double)_allProducts.Count / ItemsPerPage);

            CountPageTb.Text = $"{_currentPage} из {totalProductPages}";
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.Navigate(new StartPage());
        }
        private void BackPageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                UpdateDisplay();
            }
        }

        private void NextPAgeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage * ItemsPerPage < _allProducts.Count)
            {
                _currentPage++;
                UpdateDisplay();
            }
        }
    }
}
