<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrangThai.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLCauHinhTrangThai.TrangThai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Cấu hình Trạng thái</h2>
    <div class="search">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MaTT" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="MaTT" HeaderText="Mã Trạng Thái" 
                    InsertVisible="False" ReadOnly="True" SortExpression="MaTT" />
                <asp:BoundField DataField="TenTT" HeaderText="Tên Trạng Thái" 
                    SortExpression="TenTT" />
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# "~/QLBophan_Admin/QLCauHinhTrangThai/SuaTrangThai.aspx?MaTT=" + Eval("MaTT") %>' 
                            Text="Sửa"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField DeleteText="Xóa" HeaderText="Xóa" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            DeleteCommand="DELETE FROM [TrangThai] WHERE [MaTT] = @MaTT" 
            InsertCommand="INSERT INTO [TrangThai] ([TenTT]) VALUES (@TenTT)" 
            SelectCommand="SELECT * FROM [TrangThai]" 
            UpdateCommand="UPDATE [TrangThai] SET [TenTT] = @TenTT WHERE [MaTT] = @MaTT">
            <DeleteParameters>
                <asp:Parameter Name="MaTT" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TenTT" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TenTT" Type="String" />
                <asp:Parameter Name="MaTT" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <p>
        <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="thêm" />
&nbsp;&nbsp;
        </p>
    <br />
    <div id="ThemTT" runat=server>
    <h2>
        Thêm trạng thái</h2>
    <asp:Label ID="lbLoi" CssClass="message-error" runat="server" Text=""></asp:Label>
    <div class="form-add-customer form-content clearfix">
        <div class="form-item">
            &nbsp;<asp:Label ID="lbTen" runat="server" Text="Tên Trạng Thái: "></asp:Label>
            <asp:TextBox ID="txtTenTT" runat="server"></asp:TextBox>
        </div>
        <div class="form-item form-action">
&nbsp;<asp:Button ID="btnLuuTT" runat="server" Text="Lưu" onclick="btnLuuTT_Click" />
            <asp:Button ID="btnHuyTT" runat="server" Text="Hủy" />
        </div>
    </div>
    </div>
</asp:Content>
