<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Wth4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet"/>
    <style type="text/css">
        .auto-style1 {
            width: 308px;
        }
        .auto-style3 {
            width: 308px;
            height: 34px;
        }
        .auto-style5 {
            height: 34px;
        }
        .auto-style6 {
            width: 333px;
        }
        .auto-style7 {
            width: 333px;
            height: 34px;
        }
        .auto-style8 {
            width: 308px;
            height: 29px;
        }
        .auto-style9 {
            width: 333px;
            height: 29px;
        }
        .auto-style10 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style6" >
                    <h2>ĐĂNG KÝ PHÒNG</h2>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Họ tên</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtHoTen" runat="server" Width="247px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập họ tên" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cơ quan</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCoQuan" runat="server" Width="247px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtHoTen" ErrorMessage="Nhập cơ quan"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">E-mail</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server" Width="246px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Nhập Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Mật khẩu</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password" Width="246px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Nhập mật khẩu"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Mật khẩu dài tối thiếu 8 kí tự bao gồm 1 chữ cái 1 chữ số và 1 kí tự đặc biệt" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&amp;])[A-Za-z\d@$!%*#?&amp;]{8,}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nhập lại mật khẩu</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNhapLaiMatKhau" runat="server" TextMode="Password" Width="247px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNhapLaiMatKhau" ErrorMessage="Nhập lại mật khẩu lần hai"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMatKhau" ControlToValidate="txtNhapLaiMatKhau" ErrorMessage="Mật khẩu không khớp"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ngày checkin</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNgayCheckin" runat="server" Width="247px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="txtNgayCheckin" ErrorMessage="Nhập ngày checkin" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Số ngày ở</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtSoNgay" runat="server" Width="247px"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtSoNgay" ErrorMessage="Nhập số ngày " Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Loại phòng</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="cbxLoaiPhong" runat="server">
                        <asp:ListItem>Phòng đơn</asp:ListItem>
                        <asp:ListItem>Phòng đôi</asp:ListItem>
                        <asp:ListItem>Phòng Vip đơn</asp:ListItem>
                        <asp:ListItem>Phòng Vip đôi</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style7">
                    <asp:Button ID="btnDangKy" runat="server" OnClick="btnDangKy_Click" Text="Đăng ký" />
                    <asp:Button ID="btnGhiFile" runat="server" OnClick="btnGhiFile_Click" Text="Ghi file" />
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="lblThongBao" runat="server" Text="Thông báo"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
