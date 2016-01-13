<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoaiKH.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLCauHinhLoaiKH.LoaiKH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cấu hình loại Khách Hàng</h2>
    <div class="search">
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            DeleteCommand="DELETE FROM [LoaiKH] WHERE [MaLKH] = @MaLKH" 
            InsertCommand="INSERT INTO [LoaiKH] ([TenLKH]) VALUES (@TenLKH)" 
            SelectCommand="SELECT * FROM [LoaiKH]" 
            UpdateCommand="UPDATE [LoaiKH] SET [TenLKH] = @TenLKH WHERE [MaLKH] = @MaLKH">
            <DeleteParameters>
                <asp:Parameter Name="MaLKH" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TenLKH" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TenLKH" Type="String" />
                <asp:Parameter Name="MaLKH" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MaLKH" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:TemplateField HeaderText="Mã Loại KH" InsertVisible="False" 
                    SortExpression="MaLKH">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaLKH") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaLKH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ten Loại KH" SortExpression="TenLKH">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TenLKH") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("TenLKH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# "~/QLBophan_Admin/QLCauHinhLoaiKH/SuaLKH.aspx?MaLKH=" + Eval("MaLKH") %>' 
                            Text="Sửa"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField DeleteText="Xóa" HeaderText="Xóa" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="form-action">
    </div>
    <p>
        <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="thêm" />
&nbsp;&nbsp;
        </p>
    <br />
    <div id="ThemLoaiKH" runat=server>
    <h2>
        Thêm Loại khách hàng</h2>
    <asp:Label ID="lbLoi" CssClass="message-error" runat="server" Text=""></asp:Label>
    <div class="form-add-customer form-content clearfix">
        <div class="form-item">
            &nbsp;<asp:Label ID="lbTenLKH" runat="server" Text="Tên Loại Khách Hàng: "></asp:Label>
            <asp:TextBox ID="txtTenLKH" runat="server"></asp:TextBox>
        </div>
        <div class="form-item form-action">
&nbsp;<asp:Button ID="btnLuuKH" runat="server" Text="Lưu" onclick="btnLuuKH_Click" />
            <asp:Button ID="btnHuyKH" runat="server" Text="Hủy" />
        </div>
    </div>
    </div>
</asp:Content>
