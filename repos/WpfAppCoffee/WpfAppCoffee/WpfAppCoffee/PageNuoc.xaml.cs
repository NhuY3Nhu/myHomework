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
    /// Interaction logic for PageNuoc.xaml
    /// </summary>
    public partial class PageNuoc : Window
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KS8I3UJH\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True");
        public PageNuoc()
        {
            InitializeComponent();
            ketnoicsdl();
        }
       
        private void ketnoicsdl()
        {
            conn.Open();
            string sql = "select * from NuocUong";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            NuocUong.ItemsSource = dt.DefaultView;
        }
        private void BtThem_Click(object sender, RoutedEventArgs e)
        {
            if (txt_mnu.Text != "" && txt_tnu.Text != "" && txt_gnu.Text != "" )
            {
                conn.Open();
                string mnu = txt_mnu.Text;
                string tnu = txt_tnu.Text;
                string gnu = txt_gnu.Text;
                string sql = "Insert into NuocUong values ('" + mnu + "','" + tnu + "','" + gnu + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã Thêm Nước Uống", "THÔNG BÁO", MessageBoxButton.OK);
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
            string mnu = txt_mnu.Text;
            string sql = "Delete from NuocUong Where MaNuocUong='" + mnu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã Xóa Nước Uống", "THÔNG BÁO", MessageBoxButton.OK);
            txt_tnu.Clear();
            conn.Close();
        }

        private void BtCapNhat_Click(object sender, RoutedEventArgs e)
        {
            ketnoicsdl();
        }

        
    }
}
