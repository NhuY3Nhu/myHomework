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
using System.Configuration;

namespace WpfAppCoffee
{
    /// <summary>
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class PageKhachHang : Window
    {
       SqlConnection conn = new SqlConnection( @"Data Source=LAPTOP-KS8I3UJH\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True");
        public PageKhachHang()
        {
            InitializeComponent();
            ketnoicsdl();
            
        }
        private void ketnoicsdl()
        {
            conn.Open();
            string sql = "select * from KhachHang";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            KhachHang.ItemsSource = dt.DefaultView;
        }

        

        private void BtThem_Click(object sender, RoutedEventArgs e)
        {
            if(txt_tkh.Text!="" && txt_dt.Text!="" && txt_dc.Text!="")
            {
                conn.Open();
                string makh = txt_mkh.Text;
                string htkh = txt_tkh.Text;
                string sdtkh = txt_dt.Text;
                string dckh = txt_dc.Text;
                string sql = "Insert into KhachHang values ('" + makh + "','" + htkh + "','" + sdtkh + "','" + dckh + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã Thêm Khách Hàng", "THÔNG BÁO", MessageBoxButton.OK);
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
            string makh = txt_mkh.Text;
            string sql = "Delete from KhachHang Where MaKhachHang='" + makh + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã Xóa Khách Hàng", "THÔNG BÁO", MessageBoxButton.OK);
            txt_tkh.Clear();
            conn.Close();

        }

        private void BtCapNhat_Click(object sender, RoutedEventArgs e)
        {
            ketnoicsdl();
        }

        private void KhachHang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView row = KhachHang.SelectedItem as DataRowView;
            txt_mkh.Text = "";
            if(row !=null)
            {
                txt_mkh.Text = row.Row[0].ToString();
                txt_tkh.Text = row.Row[1].ToString(); 
                txt_dt.Text = row.Row[2].ToString();
                txt_dc.Text = row.Row[3].ToString();
                
            }    
        }
    }
}
