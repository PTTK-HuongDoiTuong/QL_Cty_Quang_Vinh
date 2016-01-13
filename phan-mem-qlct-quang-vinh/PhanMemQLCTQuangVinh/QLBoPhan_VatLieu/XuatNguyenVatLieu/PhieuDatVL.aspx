<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhieuDatVL.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.XuatNguyenVatLieu.PhiuDatVL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>PHIẾU ĐẶT VẬT LIỆU</h2>
<div>
    <asp:Label ID="Label1" runat="server" Text="Ngày đặt:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 25/5/2015</div>
<div>
    <asp:Label ID="Label3" runat="server" Text="Mã Vật Liệu: "></asp:Label>
    &nbsp;&nbsp;&nbsp; 3</div>
<div>
    <asp:Label ID="Label5" runat="server" Text="Tên Vật Liệu:"></asp:Label>
    &nbsp;&nbsp; Nhựa chấm bi</div>
<div>
    <asp:Label ID="Label10" runat="server" Text="Mã NCC:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3</div>
<div>
    <asp:Label ID="Label7" runat="server" Text="Số lượng"></asp:Label>
    :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 50</div>
<div>
    <asp:Label ID="Label8" runat="server" Text="Tổng tiền"></asp:Label>
    &nbsp;: 150000</div>
  <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server"  Text="Lưu" />
        <input type="reset" value="Huỷ" />
    </div>
</asp:Content>
