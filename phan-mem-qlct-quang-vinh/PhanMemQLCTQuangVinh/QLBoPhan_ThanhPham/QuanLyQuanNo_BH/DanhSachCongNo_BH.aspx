﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachCongNo_BH.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QuanLyQuanNo_BH.DanhSachCongNo_BH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2> DANH SÁCH CÔNG NỢ _bán hàng</h2>
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MaDH" HeaderText="Mã ĐH" />
            <asp:BoundField DataField="MaKH" HeaderText="Mã KH" />
            <asp:BoundField DataField="TenKH" HeaderText="Tên KH" />
            <asp:BoundField DataField="NgayTaoDH" DataFormatString="{0:dd/MM/yyyy}" 
                HeaderText="Ngày Đặt Hàng" />
            <asp:BoundField DataField="HanTT" DataFormatString="{0:dd/MM/yyyy}" 
                HeaderText="Hạn Thanh Toán" />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền ĐH" />
            <asp:BoundField DataField="CongNoDH" HeaderText="Công Nợ" />
            <asp:BoundField DataField="TrangThai" HeaderText="Trạng Thái" />
            <asp:TemplateField HeaderText="Thanh Toán">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='<%# "~/QLBoPhan_ThanhPham/QuanLyQuanNo_BH/ThanhToan_BH.aspx?MaDH=" +Eval("MaDH") %>' 
                        Text="Thanh Toán"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Trả Hàng">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink2" runat="server" 
                        NavigateUrl='<%# "~/QLBoPhan_ThanhPham/QuanLyQuanNo_BH/TraHang.aspx?MaDH=" +Eval("MaDH") %>' 
                        Text="Trả Hàng"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
</asp:Content>

