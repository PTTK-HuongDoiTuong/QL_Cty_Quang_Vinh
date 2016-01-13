<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhanBoThanhPham.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QLPhanBoThanhPham.PhanBoThanhPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Phiếu Giao Hàng HÀNG</h2>
<div>
        Mã Đơn Hàng:
        <asp:Label ID="lbMaDonHang" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lbMaKh" runat="server" Text="Mã Khách Hàng:"></asp:Label>
        <asp:Label ID="lbKH" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lbTenKH" runat="server" Text="Tên Khách Hàng:"></asp:Label>
        <asp:Label ID="lbTenKhachHang" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="Label3" runat="server" Text="Ngày Lập Phiếu:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lbngayLap" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Ngày Đặt Đơn Hàng:"></asp:Label>
        &nbsp;&nbsp;&nbsp;<asp:Label ID="lbNgaydat" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Mã Phiếu Giao Hàng: "></asp:Label>
        <asp:TextBox ID="txtMaPG" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="Label5" runat="server" Text="Mã Nhân Viên:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMaNV" runat="server" Width="67px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>

    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <H3>DANH SÁCH CÁC SẢN PHẨM</H3></div>

    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
                <asp:BoundField DataField="Gia" HeaderText="Giá Sản Phẩm" />
                <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
                <asp:BoundField DataField="ThanhTien" HeaderText="Thành Tiền" />
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Tổng tiền"></asp:Label>
        :&nbsp;
        <asp:Label ID="lbTong" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </div>

    <div>
    </div>

   <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" Text="Lưu" onclick="btnLuu_Click" />
        <input type="reset" value="HỦY" />
        <br />
    </div>
</asp:Content>
