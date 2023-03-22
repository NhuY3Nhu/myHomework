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
using System.Data;
using System.Data.SqlClient;

namespace WpfAppCoffee
{
    /// <summary>
    /// Interaction logic for PageNhanVien.xaml
    /// </summary>
    public partial class PageNhanVien : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KS8I3UJH\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True");
        public PageNhanVien()
        {
            InitializeComponent();
            ketnoicsdl();
        }
        private void ketnoicsdl()
        {
            conn.Open();
            string sql = "select * from NhanVien";
            SqlCommand com = new SqlCommand(sql, conn);
            //com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            NhanVien.ItemsSource = dt.DefaultView;
        }

        private void BtThem_Click(object sender, RoutedEventArgs e)
        {
            if (txt_mnv.Text != "" && txt_tnv.Text != "" && txt_dcnv.Text != "" && txt_dt.Text != "" && txt_gt.Text != "")
            {
                conn.Open();
                string mnv = txt_mnv.Text;
                string tnv = txt_tnv.Text;
                string dcnv = txt_dcnv.Text;
                string dt = txt_dt.Text;
                string gt = txt_gt.Text;
                string sql = "Insert into NhanVien values ('" + mnv + "','" + tnv + "','" + dcnv + "','" + dt + "','" + gt + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã Thêm Nhân Viên", "THÔNG BÁO", MessageBoxButton.OK);
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "THÔNG BÁO", MessageBoxButton.OK);
            }
        }



        private void BtXoa_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            string mnv = txt_mnv.Text;
            string sql = "Delete from NhanVien Where MaNhanVien='" + mnv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã Xóa Nhân Viên", "THÔNG BÁO", MessageBoxButton.OK);
            txt_tnv.Clear();
            conn.Close();
        }

        private void BtCapNhat_Click(object sender, RoutedEventArgs e)
        {
            ketnoicsdl();
        }

       
    }
}
