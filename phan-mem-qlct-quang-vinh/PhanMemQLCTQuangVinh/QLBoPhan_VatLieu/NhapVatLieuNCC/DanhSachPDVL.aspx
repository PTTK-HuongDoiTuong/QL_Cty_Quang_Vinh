<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachPDVL.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.NhapVatLieuNCC.DanhSachPDVL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>DANH SÁCH PHIẾU ĐẶT VẬT LIỆU</h2>
    <asp:GridView ID="gridDSPhieuDat" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" onpageindexchanging="gridDSPhieuDat_PageIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="Mã Phiếu Đặt">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("MaPDVLCC") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaPDVLCC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ngày đặt">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NgayLap") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("NgayLap") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nhà cung cấp">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("dtoncc.TenNCC") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("dtoncc.TenNCC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Trạng thái">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("TrangThai") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbTrangThai" runat="server" Text='<%# Bind("TrangThai") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nhập Vật Liệu">
                <ItemTemplate>
                    <asp:HyperLink ID="linkXuLy" runat="server" NavigateUrl='<%# "~/QLBoPhan_VatLieu/NhapVatLieuNCC/NhapVatLieu.aspx?maPhieu=" + Eval("MaPDVLCC") %>' Text="Xử lý"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
