<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachPhieuDatVL_SX.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_SanXuat.NhapVatLieu_SX.DanhSachPhieuDatVL_SX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>DANH SÁCH PHIẾU ĐẶT VẬT LIỆU SẢN XUẤT</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="MaPD_VLSX" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:TemplateField HeaderText="MaPD_VLSX" InsertVisible="False" 
                SortExpression="MaPD_VLSX">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaPD_VLSX") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaPD_VLSX") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NgayDat" SortExpression="NgayDat">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("NgayDat") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("NgayDat") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TrangThai" SortExpression="TrangThai">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TrangThai") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("TrangThai") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xử lý nhập">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" Text="Xử lý"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
        SelectCommand="SELECT [MaPD_VLSX], [NgayDat], [TrangThai] FROM [PhieuDatVL_SX]">
    </asp:SqlDataSource>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server">
    </asp:AccessDataSource>
</asp:Content>
