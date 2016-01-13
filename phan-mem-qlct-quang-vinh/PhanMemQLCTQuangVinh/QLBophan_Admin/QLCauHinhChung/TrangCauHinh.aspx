<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrangCauHinh.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLCauHinhChung.TrangCauHinh" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Trang Cấu Hình</h2>
    <br />
    <div class="form-action" align="center">
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/QLBophan_Admin/QLCauHinhLoaiSP/LoaiSP.aspx">Cấu Hình Loại Thành Phẩm</asp:HyperLink>

        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="~/QLBophan_Admin/QLCauHinhLoaiKH/LoaiKH.aspx">Cấu Hình Loại Khách Hàng</asp:HyperLink>

        <br />

        <asp:HyperLink ID="HyperLink6" runat="server" 
            NavigateUrl="~/QLBophan_Admin/QLCauHinhTrangThai/TrangThai.aspx">Cấu Hình Trạng Thái</asp:HyperLink>

        <asp:HyperLink ID="HyperLink5" runat="server" 
            NavigateUrl="~/QLBophan_Admin/QLCauHinhNCC/NCC.aspx">Cấu Hình Nhà Cung Cấp</asp:HyperLink>
    </div>
</asp:Content>
