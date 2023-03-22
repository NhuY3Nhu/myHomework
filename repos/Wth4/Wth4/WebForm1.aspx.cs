using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wth4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblThongBao.Text = string.Format("Bạn {0} đã đăng ký thành công!, Cơ quan là: {1}, " +
                    "Email là: {2}, " + "Ngày Checkin là: {3}, " + "Ngày ở là: {4}, ", txtHoTen.Text, txtCoQuan.Text,
                    txtEmail.Text, txtNgayCheckin.Text, txtSoNgay.Text);
            }
        }
        protected void btnGhiFile_Click(object sender, EventArgs e)
        {
            string sfile = Server.MapPath(@"\") + "Ghi.txt";
            using(StreamWriter writer=new StreamWriter(sfile,true))
            {
                writer.WriteLine(txtHoTen.Text);
                writer.WriteLine(txtCoQuan.Text);
                writer.WriteLine(txtEmail.Text);
                writer.WriteLine(txtMatKhau.Text);
                writer.WriteLine(txtNgayCheckin.Text);
                writer.WriteLine(txtSoNgay.Text);
                
                writer.WriteLine("------END-----");
                writer.Close();
            }    
        }
    }
}