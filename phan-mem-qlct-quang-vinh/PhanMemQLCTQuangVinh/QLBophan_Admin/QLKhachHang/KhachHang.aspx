﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="PhanMemQLCTQuangVinh.KhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>DANH SÁCH KHÁCH HÀNG</h2>
    <div class="search">
        <asp:TextBox ID="txtTimTen" runat="server" placeholder="Nhập tên để tìm..."></asp:TextBox>
        <asp:Button ID="btnTim" runat="server" Text="Tìm" onclick="btnTim_Click" />
    </div>

    <asp:GridView ID="GridKH" runat="server" AllowPaging="True" 
    AllowSorting="True" BorderStyle="Solid" CssClass="bang-khach-hang" 
        AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderWidth="1px" onrowcommand="GridDSKH_RowCommand" 
         >
        <Columns>
            <asp:TemplateField HeaderText="Mã khách hàng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("MaKH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaKH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên khách hàng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TenKH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("TenKH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Địa chỉ">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("DiaChiKH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("DiaChiKH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số điện thoại">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("SdtKH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("SdtKH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Loại Khách hàng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("dtoLoaiKH.TenLKH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("dtoLoaiKH.TenLKH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                <%--link toi trang sua KH: Eval lay MaKH can sua--%>
                    <asp:HyperLink CssClass="fa fa-edit edit" ID="HyperLink1" runat="server" NavigateUrl='<%# "~/QLBoPhan_TiepNhanKH/QLKhachHang/SuaKhachHang.aspx?MaKH=" + Eval("MaKH") %>' Text="Sửa"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xóa" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton CssClass="fa fa-remove remove" OnClientClick='return confirm("Bạn có muốn xóa?")' ID="btnXoa" runat="server" CausesValidation="false" 
                        CommandName="cmdXoa" CommandArgument='<%# Eval("MaKH") %>' Text="Xóa" EnableTheming="false"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="form-action">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/QLBoPhan_TiepNhanKH/QLDonHang/ThemDonHang.aspx">Tạo đơn hàng</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/QLBoPhan_TiepNhanKH/QLKhachHang/ThemKhachHang.aspx">Thêm khách hàng</asp:HyperLink>
    </div>
    </asp:Content>