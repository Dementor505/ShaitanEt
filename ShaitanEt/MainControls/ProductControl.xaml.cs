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

namespace ShaitanEt.MainControls
{
    /// <summary>
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        public ProductControl(Product product, BitmapImage imageSource)
        {
            InitializeComponent();
            NameProduct.Text = product.Name_Product;
            CostProduct.Text = product.Cost.ToString() + ".р";
            ImagePhoto.Source = imageSource;
        }
    }
}
