<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QuanlyLoaiKH.aspx.cs" Inherits="PhanMemQLCTQuangVinh.LoaiKH.ThemLoaiKH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <table id="table2" style="width: 121%;">
    <tr>
        <td>
            <h2>
                Quản Lý Loại Khách Hàng</h2>
        </td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp; Nhập mã loại khách hàng:
            <asp:TextBox ID="TextBox1" runat="server" Width="149px"></asp:TextBox>
            <asp:ImageButton ID="btTim" runat="server" 
                ImageUrl="~/Hinh/button_timkiem.png" />
        </td>
    </tr>
    <tr>
        <td class="style4">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                GridLines="Vertical" AutoGenerateColumns="False" DataKeyNames="MaLKH" 
                DataSourceID="SqlDataSource1">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="MaLKH" HeaderText="MaLKH" InsertVisible="False" 
                        ReadOnly="True" SortExpression="MaLKH" />
                    <asp:BoundField DataField="TenLKH" HeaderText="TenLKH" 
                        SortExpression="TenLKH" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:CTyQuangVinhConnectionString3 %>" 
                SelectCommand="SELECT * FROM [LoaiKH]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="style9">
    <table id="table3" runat=server style="width: 104%; height: 249px;">
        <tr>
            <td colspan="3">
                <h2>
                    &nbsp;&nbsp;&nbsp;&nbsp; Thêm loại khách hàng</h2>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4" colspan="2">
                <asp:Label ID="lbThemUser" runat="server" Text="Thông Báo Lỗi" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                Mã loại khách hàng:</td>
            <td>
                <asp:TextBox ID="tbTenDN" runat="server" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                Tên loại khách hàng</td>
            <td>
                <asp:TextBox ID="tbMK" runat="server" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                </td>
            <td class="style11">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Lưu" 
                    Width="79px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Thoát" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
            <br />
    <table id="tbSua" runat=server style="width: 100%;">
        <tr>
            <td colspan="3">
                <h2>
                    &nbsp;&nbsp;&nbsp;&nbsp; Sửa loại khách hàng</h2>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4" colspan="2">
                <asp:Label ID="lbSuaTK" runat="server" Text="Thông Báo Lỗi" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                Mã loại khách hàng:</td>
            <td>
                <asp:TextBox ID="tbTenDN1" runat="server" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                Tên loại khách hàng:</td>
            <td>
                <asp:TextBox ID="tbMK1" runat="server" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;<asp:Button ID="btluuS" runat="server" onclick="btluuS_Click" Text="Lưu" 
                    Width="63px" />
&nbsp;<asp:Button ID="btThoatS" runat="server" onclick="btThoatS_Click" Text="Thoát" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table id="tbXoa" runat=server style="width: 100%;">
        <tr>
            <td colspan="3">
                <h2>
                    &nbsp;&nbsp;&nbsp;&nbsp; Xóa loại khách hàng</h2>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style4" colspan="2">
                <asp:Label ID="lbXoaUser" runat="server" Text="Thông Báo Lỗi" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style10">
                Nhập mã loại khách hàng:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="249px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style10">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;<asp:Button ID="btXoatk" runat="server" onclick="btXoatk_Click" 
                    Text="Xóa" />
&nbsp;&nbsp;
                <asp:Button ID="btThoatX" runat="server" Text="Thoát" 
                    onclick="btThoatX_Click" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
            <br />
        </td>
    </tr>
</table>
</asp:Content>
