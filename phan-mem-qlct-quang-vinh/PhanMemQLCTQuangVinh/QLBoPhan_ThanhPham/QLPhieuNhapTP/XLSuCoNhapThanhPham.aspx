<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="XLSuCoNhapThanhPham.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QLPhieuNhapTP.XLSuCoNhapThanhPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Xử Lý Sự Cố Nhập Thành Phẩm</h2>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Mã Phiếu Nhập SP:"></asp:Label>
        &nbsp;<asp:Label ID="lbMaPhieuNhap" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Mã Phiếu Giao: "></asp:Label>
        <asp:Label ID="lbMaPG" runat="server"></asp:Label>
    </p>
    <h3>
        Sản Phẩm Có Sự Cố
    </h3>
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:BoundField DataField="MaNSP" HeaderText="Mã Phiếu Nhập SP" />
            <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm" />
            <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="Soluong" HeaderText="Số Lượng Hư" />
        </Columns>
    </asp:GridView>
    </p>
    <asp:Button ID="btnLuu" runat="server" Text="Lưu" />
    <br />
</asp:Content>
