<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NCC.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLCauHinhNCC.NCC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Cấu hình Nhà cung cấp</h2>
    <div class="search">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MaNCC" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="MaNCC" HeaderText="Mã NCC" InsertVisible="False" 
                    ReadOnly="True" SortExpression="MaNCC" />
                <asp:BoundField DataField="TenNCC" HeaderText="Tên NCC" 
                    SortExpression="TenNCC" />
                <asp:BoundField DataField="Sdt" HeaderText="SĐT" SortExpression="Sdt" />
                <asp:BoundField DataField="Diachi" HeaderText="Địa Chỉ" 
                    SortExpression="Diachi" />
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# "~/QLBophan_Admin/QLCauHinhNCC/SuaNCC.aspx?MaNCC=" + Eval("MaNCC") %>' 
                            Text="Sửa"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField DeleteText="Xóa" HeaderText="Xóa" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            DeleteCommand="DELETE FROM [NhaCungCap] WHERE [MaNCC] = @MaNCC" 
            InsertCommand="INSERT INTO [NhaCungCap] ([TenNCC], [Sdt], [Diachi]) VALUES (@TenNCC, @Sdt, @Diachi)" 
            SelectCommand="SELECT * FROM [NhaCungCap]" 
            UpdateCommand="UPDATE [NhaCungCap] SET [TenNCC] = @TenNCC, [Sdt] = @Sdt, [Diachi] = @Diachi WHERE [MaNCC] = @MaNCC">
            <DeleteParameters>
                <asp:Parameter Name="MaNCC" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TenNCC" Type="String" />
                <asp:Parameter Name="Sdt" Type="String" />
                <asp:Parameter Name="Diachi" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TenNCC" Type="String" />
                <asp:Parameter Name="Sdt" Type="String" />
                <asp:Parameter Name="Diachi" Type="String" />
                <asp:Parameter Name="MaNCC" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <div class="form-action">
        <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="thêm" />
    </div>
    <br />
    <div id="ThemNCC" runat=server>
    <h2>
        Thêm Nhà cung cấp</h2>
    <asp:Label ID="lbLoi" CssClass="message-error" runat="server" Text=""></asp:Label>
    <div class="form-content form-edit-custom">
        <div class="form-item">
            <asp:Label ID="lbTencc" runat="server" Text="Tên Nhà Chung Cấp: "></asp:Label>
            <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="lbdt" runat="server" Text="Số Điện Thoại: "></asp:Label>
            <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="lbdiachi" runat="server" Text="Địa Chỉ NCC:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
        </div>
        <div class="form-item form-action">
            <asp:Button ID="btnLu" runat="server" onclick="btnLu_Click" Text="Lưu" />
            <asp:Button ID="btnHy" runat="server" Text="Hủy" />
        </div>
    </div>
    </div>
</asp:Content>
