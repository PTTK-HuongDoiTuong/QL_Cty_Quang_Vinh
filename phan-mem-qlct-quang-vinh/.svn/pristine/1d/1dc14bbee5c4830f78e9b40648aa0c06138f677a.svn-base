<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoaiSP.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLCauHinhLoaiSP.LoaiSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Cấu hình loại Sản Phẩm</h2>
    <div class="search">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MaLoai" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="MaLoai" HeaderText="Mã Loại SP" InsertVisible="False" 
                    ReadOnly="True" SortExpression="MaLoai" />
                <asp:BoundField DataField="TenLoai" HeaderText="Tên Loại SP" 
                    SortExpression="TenLoai" />
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# "~/QLBophan_Admin/QLCauHinhLoaiSP/SuaLoaiSP.aspx?MaLoai=" + Eval("MaLoai") %>' 
                            Text="Sửa"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField DeleteText="Xóa" HeaderText="Xóa" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div class="form-action">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            DeleteCommand="DELETE FROM [LoaiSP] WHERE [MaLoai] = @MaLoai" 
            InsertCommand="INSERT INTO [LoaiSP] ([TenLoai]) VALUES (@TenLoai)" 
            SelectCommand="SELECT * FROM [LoaiSP]" 
            
            UpdateCommand="UPDATE [LoaiSP] SET [TenLoai] = @TenLoai WHERE [MaLoai] = @MaLoai">
            <DeleteParameters>
                <asp:Parameter Name="MaLoai" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TenLoai" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TenLoai" Type="String" />
                <asp:Parameter Name="MaLoai" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <p>
        <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="thêm" />
&nbsp;&nbsp;
        </p>
    <br />
    <div id="ThemLoaiSP" runat=server>
    <h2>
        Thêm Loại sản phẩm</h2>
    <asp:Label ID="lbLoi" CssClass="message-error" runat="server" Text=""></asp:Label>
    <div class="form-add-customer form-content clearfix">
        <div class="form-item">
            &nbsp;<asp:Label ID="txtTen" runat="server" Text="Tên Loại Sản Phẩm: "></asp:Label>
            <asp:TextBox ID="txtLSP" runat="server"></asp:TextBox>
        </div>
        <div class="form-item form-action">
&nbsp;<asp:Button ID="btnLuuSP" runat="server" Text="Lưu" onclick="btnLuuSP_Click" />
            <asp:Button ID="btnHuySP" runat="server" Text="Hủy" />
        </div>
    </div>
    </div>
</asp:Content>
