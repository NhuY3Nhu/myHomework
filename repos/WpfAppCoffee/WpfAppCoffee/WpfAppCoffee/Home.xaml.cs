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
using WpfAppCoffee;

namespace WpfAppCoffee
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_KhachHang(object sender, RoutedEventArgs e)
        {
            PageKhachHang KH = new PageKhachHang();
            KH.ShowDialog();
        }

        private void btn_NhanVien(object sender, RoutedEventArgs e)
        {
            PageNhanVien NV = new PageNhanVien();
            NV.ShowDialog();
        }

        
        private void btn_Nuoc(object sender, RoutedEventArgs e)
        {
            PageNuoc NC = new PageNuoc();
            NC.ShowDialog();
        }
    }
}
