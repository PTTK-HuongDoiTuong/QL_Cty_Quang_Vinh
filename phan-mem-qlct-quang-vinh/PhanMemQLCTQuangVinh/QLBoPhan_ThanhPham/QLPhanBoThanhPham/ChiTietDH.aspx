﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTietDH.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QLPhanBoThanhPham.ChiTietDH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>PHÂN BỔ THÀNH PHẨM</h2>
    <div>
        <asp:Label ID="lbDH" runat="server" Text="Mã Đơn Hàng: "></asp:Label>
        <asp:Label ID="lbMaDH" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lbMaKH" runat="server" Text="Mã Khách Hàng: "></asp:Label>
        <asp:Label ID="lbKH" runat="server" Text="Label"></asp:Label>
    </div>
    <p>
        &nbsp;</p>
        <h3>DANH SÁCH CHI TIẾT ĐƠN HÀNG</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MaDH" HeaderText="Mã ĐH" />
            <asp:BoundField DataField="MaSP" HeaderText="Mã SP" />
            <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
        </Columns>
    </asp:GridView>
    </p>
    <div id="XemDSKho" runat=server>
        <h3>DANH SÁCH CÁC SẢN PHẨM CÓ TRONG KHO</h3>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="STT" HeaderText="STT" />
                <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
                <asp:BoundField DataField="Soluong" HeaderText="Số Lượng" />
            </Columns>
        </asp:GridView>
    </div>
    <p>
        &nbsp;</p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            SelectCommand="SELECT * FROM [SanPham]"></asp:SqlDataSource>
       <h3>CHỌN THÀNH PHẨM VÀ NHẬP SỐ LƯỢNG CẦN GIAO</h3>
    <asp:Label ID="lbMaSP" runat="server" Text="Tên Sản Phẩm: "></asp:Label>
    <asp:DropDownList ID="ddTP" runat="server" DataSourceID="SqlDataSource1" 
        DataTextField="TenSP" DataValueField="MaSP" 
        onselectedindexchanged="ddTP_SelectedIndexChanged" AppendDataBoundItems="True">
         <asp:ListItem Value="-1">---Chọn Thành Phẩm -----</asp:ListItem>
    </asp:DropDownList>
    &nbsp;<asp:Label 
        ID="lbgia" runat="server"></asp:Label>
    <asp:Label 
        ID="lbSLKho" runat="server"></asp:Label>
    &nbsp;<br />
    &nbsp;<asp:Label ID="lbSL" runat="server" Text="Số Lượng: "></asp:Label>
    <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnThemSP" runat="server" Text="Thêm Vào Danh Sách" 
            onclick="btnThemSP_Click" />
    </p>
    <p>
       <h3>DANH SÁCH XUẤT PHIẾU GIAO</h3></p>
    <p>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
                <asp:BoundField DataField="Soluong" HeaderText="Số Lượng" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnXuat" runat="server" onclick="btnXuat_Click" 
            Text="Xuất Phiếu Giao" />
    </p>
</asp:Content>
