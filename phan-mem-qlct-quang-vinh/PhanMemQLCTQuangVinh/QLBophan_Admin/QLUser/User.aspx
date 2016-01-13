<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLUser.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Danh Sách Tài Khoản người dùng</h2>
    <div class="search">
        <asp:TextBox ID="txtTim" runat="server"></asp:TextBox>
        <asp:Button ID="btnTim" runat="server" Text="Tìm" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="IDUser" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="IDUser" HeaderText="ID User" ReadOnly="True" 
                    SortExpression="IDUser" />
                <asp:BoundField DataField="MatKhau" HeaderText="Mật Khẩu" 
                    SortExpression="MatKhau" />
                <asp:BoundField DataField="HoTenUser" HeaderText="Họ Thên USer" 
                    SortExpression="HoTenUser" />
                <asp:BoundField DataField="MaNhomQ" HeaderText="Nhóm Quyền" 
                    SortExpression="MaNhomQ" />
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# "~/QLBophan_Admin/QLUser/SuaUser.aspx?IDUser=" + Eval("IDUser") %>' 
                            Text="Sửa"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField DeleteText="Xóa" HeaderText="Xóa" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            DeleteCommand="DELETE FROM [User] WHERE [IDUser] = @IDUser" 
            InsertCommand="INSERT INTO [User] ([IDUser], [MatKhau], [HoTenUser], [MaNhomQ]) VALUES (@IDUser, @MatKhau, @HoTenUser, @MaNhomQ)" 
            SelectCommand="SELECT * FROM [User]" 
            UpdateCommand="UPDATE [User] SET [MatKhau] = @MatKhau, [HoTenUser] = @HoTenUser, [MaNhomQ] = @MaNhomQ WHERE [IDUser] = @IDUser">
            <DeleteParameters>
                <asp:Parameter Name="IDUser" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="IDUser" Type="String" />
                <asp:Parameter Name="MatKhau" Type="String" />
                <asp:Parameter Name="HoTenUser" Type="String" />
                <asp:Parameter Name="MaNhomQ" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="MatKhau" Type="String" />
                <asp:Parameter Name="HoTenUser" Type="String" />
                <asp:Parameter Name="MaNhomQ" Type="Int32" />
                <asp:Parameter Name="IDUser" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <div class="form-action">
        <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="Thêm" />
    </div>
    <br />
    <div id = "ThemUser" runat=server>
        <h2>
            Thêm khách hàng</h2>
        <asp:Label ID="lbLoi" runat="server" CssClass="message-error" Text=""></asp:Label>
        <div class="form-add-customer form-content clearfix">
            <div class="form-item">
                <asp:Label ID="lbID" runat="server" Text="ID User: "></asp:Label>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </div>
            <div class="form-item">
                <asp:Label ID="lbMK" runat="server" Text="Mật Khẩu: "></asp:Label>
                <asp:TextBox ID="txtMK" runat="server"></asp:TextBox>
            </div>
            <div class="form-item">
                <asp:Label ID="lbHoTen" runat="server" Text="Họ Tên User: "></asp:Label>
                <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            </div>
            <div class="form-item">
                <asp:Label ID="lbNhomQ" runat="server" Text="Nhóm Quyền: "></asp:Label>
                <asp:DropDownList ID="ddlNhomQ" runat="server">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
                    SelectCommand="SELECT * FROM [NhomQuyen]"></asp:SqlDataSource>
            </div>
            <div class="form-item form-action">
                &nbsp;<asp:Button ID="btnLuuUser" runat="server" Text="Lưu" 
                    onclick="btnLuuUser_Click" />
                <asp:Button ID="btnHuyUser" runat="server" Text="Hủy" />
            </div>
        </div>
    </div>
</asp:Content>
