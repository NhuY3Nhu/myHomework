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
using System.Data;
using System.Data.SqlClient;

namespace WpfAppCoffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KS8I3UJH\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DangNhap(object sender, RoutedEventArgs e)
        {
            string dangnhap = tbTenDangNhap.Text;
            string matkhau = tbMatKhau.Password;
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
            bool kiemTra1 = false;
            bool kiemTra2 = false;
            SqlDataReader rdr = null;
            string sql = "select * from DangNhap";
            SqlCommand cmd = new SqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (dangnhap.Trim() == rdr["Tendangnhap"].ToString().Trim())
                {
                    kiemTra1 = true;
                    if (matkhau.Trim() == rdr["Matkhau"].ToString().Trim())
                    {
                        kiemTra2 = true;
                    }
                    break;
                }
            }

            if (dangnhap == "" && matkhau == "")
                MessageBox.Show("Nhập tên đăng nhập và mật khẩu");
            else if (dangnhap == "")
                MessageBox.Show("Nhập tên đăng nhập");
            else if (matkhau == "")
                MessageBox.Show("Nhập mật khẩu");
            else if (!kiemTra1)
                MessageBox.Show("Nhập sai tên đăng nhập");
            else if (!kiemTra2)
                MessageBox.Show("Nhập sai mật khẩu");
            else
            {
                Home f = new Home();
                this.Close();
                f.Show();
            }
            conn.Close();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
