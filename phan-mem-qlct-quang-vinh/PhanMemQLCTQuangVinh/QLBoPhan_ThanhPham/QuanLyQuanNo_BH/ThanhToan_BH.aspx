<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThanhToan_BH.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QuanLyQuanNo_BH.ThanhToan_BH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>PHIẾU THANH TOÁN</h2>
    <div class="form-content">
        <div class="form-item">
            <asp:Label ID="Label1" runat="server" Text="Mã Đơn Hàng: " AssociatedControlID="lbMaDH"></asp:Label>
            <asp:Label ID="lbMaDH" runat="server"></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="Label2" runat="server" Text="Mã Khách Hàng: " AssociatedControlID="lbMaKH"></asp:Label>
            <asp:Label ID="lbMaKH" runat="server"></asp:Label>
            
        </div>
        <div class="form-item">
            <asp:Label ID="Label5" runat="server" Text="Tên Khách Hàng: " AssociatedControlID="lbTenKH"></asp:Label>
            <asp:Label ID="lbTenKH" runat="server"></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="lbTongTien" runat="server" Text="Tiền Phải Trả: " AssociatedControlID="lbTienTra"></asp:Label>
            <asp:Label ID="lbTienTra" runat="server"></asp:Label>    
        </div>
        <div class="form-item">
            <asp:Label ID="Label10" runat="server" Text="Tiền Trả Nợ: " AssociatedControlID="txtTienTT"></asp:Label>
            <asp:TextBox ID="txtTienTT" runat="server"></asp:TextBox>
        </div>
        <div  class="form-item">
            <asp:Label ID="Label8" runat="server" Text="Ngày Trả Nợ: " AssociatedControlID="lbNgayTra"></asp:Label>
            <asp:Label ID="lbNgayTra" runat="server"></asp:Label>   
        </div>
            <div class="form-item">
                <asp:Label ID="Label7" runat="server" Text="Mã Nhân Viên: " AssociatedControlID="txtMaNV"></asp:Label>
                <asp:TextBox ID="txtMaNV" runat="server"></asp:TextBox>
            </div>
    </div>

<div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" onclick="btnLuu_Click" Text="Lưu" />
        <input type="reset" value="Huỷ" />
    </div>
</asp:Content>

