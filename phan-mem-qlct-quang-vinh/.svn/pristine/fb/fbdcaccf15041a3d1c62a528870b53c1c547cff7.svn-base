<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DSKhachHang.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_TiepXucKH.DSKhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>DANH SÁCH KHÁCH HÀNG</h2>
    <div class="search">
        <asp:TextBox ID="txtTim" runat="server" placeholder="Nhập tên để tìm..."></asp:TextBox>
        <asp:Button ID="btnTim" runat="server" Text="Tìm" onclick="btnTim_Click" />
    </div>

    <asp:GridView ID="GridDSKH" runat="server" AutoGenerateColumns="False">
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
            <asp:TemplateField HeaderText="Tạo Đơn Hàng">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='<%# "~/QLBoPhan_TiepXucKH/TaoDonHang.aspx?MaKH=" + Eval("MaKH") %>' 
                        Text="Tạo Đơn Hàng"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="form-action">
        <asp:Button ID="btnThem" runat="server" Text="Thêm Khách Hàng" 
            onclick="btnThem_Click" />
    </div>
    <br />
    <div id="ThemKH" runat=server>
    <h2>Thêm khách hàng</h2>

    <asp:Label ID="lbLoi" CssClass="message-error" runat="server" Text=""></asp:Label>

    <div class="form-add-customer form-content clearfix">
        <div class="form-item">
            <asp:Label ID="lbTenKH" runat="server" Text="Tên khách hàng *" AssociatedControlID="txtTenKH"></asp:Label>
            <asp:TextBox ID="txtTenKH" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="lbDiaChi" runat="server" Text="Địa chỉ *" AssociatedControlID="txtDiaChi"></asp:Label>
            <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="lbSdt" runat="server" Text="Số điện thoại *" AssociatedControlID="txtSdt"></asp:Label>
            <asp:TextBox ID="txtSdt" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="lbLoaiKH" runat="server" Text="Loại" AssociatedControlID="ddLoaiKH"></asp:Label>
            <asp:DropDownList ID="ddLoaiKH" runat="server">
            </asp:DropDownList>
        </div>
        <div class="form-item form-action">
            &nbsp;<asp:Button ID="btnLuu" runat="server" onclick="btnLuu_Click" 
                Text="Lưu" />
            <asp:Button ID="btnHuy" runat="server" Text="Hủy" />
        </div>
    </div>

    </div>
</asp:Content>
