<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhieuNVL_BPSX.aspx.cs" Inherits="PhanMemQLCTQuangVinh.PhieuNVL_BPSX.PhieuNVL_BPSX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style4
        {
            font-size: x-large;
        }
        .style5
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 113%;">
        <tr>
            <td class="style4" colspan="6">
                <h3>
                    <strong>Phiếu nhập nguyên vật liệu (BPSX)</h3>
                </strong>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                Nhập mã phiếu cần tra cứu:
                <input id="Text1" type="text" />&nbsp;
            <asp:ImageButton ID="btTim" runat="server" 
                ImageUrl="~/Hinh/button_timkiem.png" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" DataKeyNames="MaPNVLSX" DataSourceID="SqlDataSource1" 
                    GridLines="Horizontal" Height="148px" Width="403px">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="MaPNVLSX" HeaderText="Mã phiếu" ReadOnly="True" 
                            SortExpression="MaPNVLSX" />
                        <asp:BoundField DataField="Ngaylap" HeaderText="Ngày lập" 
                            SortExpression="Ngaylap" />
                        <asp:BoundField DataField="MaVL" HeaderText="Mã vật liệu" 
                            SortExpression="MaVL" />
                        <asp:BoundField DataField="Soluong" HeaderText="Số lượng" 
                            SortExpression="Soluong" />
                        <asp:BoundField DataField="Ghichu" HeaderText="Ghi chú" 
                            SortExpression="Ghichu" />
                        <asp:CommandField CancelText="Huỷ" DeleteText="Xoá" EditText="Sửa" 
                            HeaderText="Sửa Xoá" ShowDeleteButton="True" ShowEditButton="True" 
                            UpdateText="Lưu" />
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CTyQuangVinhConnectionString10 %>" 
                    DeleteCommand="DELETE FROM [PhieuNVL_SX] WHERE [MaPNVLSX] = @MaPNVLSX" 
                    InsertCommand="INSERT INTO [PhieuNVL_SX] ([MaPNVLSX], [Ngaylap], [MaVL], [Soluong], [Ghichu]) VALUES (@MaPNVLSX, @Ngaylap, @MaVL, @Soluong, @Ghichu)" 
                    SelectCommand="SELECT * FROM [PhieuNVL_SX]" 
                    UpdateCommand="UPDATE [PhieuNVL_SX] SET [Ngaylap] = @Ngaylap, [MaVL] = @MaVL, [Soluong] = @Soluong, [Ghichu] = @Ghichu WHERE [MaPNVLSX] = @MaPNVLSX">
                    <DeleteParameters>
                        <asp:Parameter Name="MaPNVLSX" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="MaPNVLSX" Type="String" />
                        <asp:Parameter Name="Ngaylap" Type="DateTime" />
                        <asp:Parameter Name="MaVL" Type="Int32" />
                        <asp:Parameter Name="Soluong" Type="Int32" />
                        <asp:Parameter Name="Ghichu" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Ngaylap" Type="DateTime" />
                        <asp:Parameter Name="MaVL" Type="Int32" />
                        <asp:Parameter Name="Soluong" Type="Int32" />
                        <asp:Parameter Name="Ghichu" Type="String" />
                        <asp:Parameter Name="MaPNVLSX" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <h2>
                    <strong>Thêm phiếu nhập VL (BPSX)</strong></h2>
            </td>
        </tr>
        <tr>
            <td class="style5" colspan="6">
            </td>
        </tr>
        <tr>
            <td colspan="6">
                Mã phiếu nhập:
                <asp:TextBox ID="TextBox1" runat="server" Width="97px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                Ngày lập:
            </td>
        </tr>
        <tr>
            <td colspan="6">
                Mã vật liệu:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="94px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                Số lượng:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Width="58px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                Ghi chú:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Height="44px" Width="320px"></asp:TextBox>
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="Button1" runat="server" Text="Lưu" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Thoát" />
            </td>
            <td colspan="3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
