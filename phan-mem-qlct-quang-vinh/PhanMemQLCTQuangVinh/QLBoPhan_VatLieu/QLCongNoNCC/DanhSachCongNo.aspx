<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachCongNo.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.QLCongNoNCC.DanhSachCongNo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2> DANH SÁCH CÔNG NỢ _NHÀ CUNG CẤP</h2>
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MaPDVLCC" HeaderText="Mã Phiếu Đặt" />
            <asp:BoundField DataField="MaNCC" HeaderText="Mã NCC" />
            <asp:BoundField DataField="TenNCC" HeaderText="Tên NCC" />
            <asp:BoundField DataField="NgayLap" HeaderText="Ngày Lập CN" />
            <asp:BoundField DataField="NgayGiao" HeaderText="Ngày Giao" />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền PĐ" />
            <asp:BoundField DataField="CongNoNCC" HeaderText="Công Nợ NCC" />
            <asp:TemplateField HeaderText="Thanh Toán">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='<%# "~/QLBoPhan_VatLieu/QLCongNoNCC/ThanhToan.aspx?MaPDVLCC=" +Eval("MaPDVLCC") %>' 
                        Text="Thanh Toán"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
