<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NhapVatLieu_SanXuat.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_SanXuat.NhapVatLieu_SX.NhapVatLieu_SanXuat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>XỬ LÝ NHẬP VẬT LIỆU SẢN XUẤT</h2>
<div>
    <asp:Label ID="Label1" runat="server" Text="Mã Phiếu Đặt"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    1</div>
<div>
    <asp:Label ID="Label2" runat="server" Text="Ngày giao"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label3" runat="server" Text="Ngày nhập"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    1/5/2015</div>
<div>
    <asp:Label ID="Label5" runat="server" Text="Mã Nhân Viên"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label7" runat="server" Text="Mã NCC"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="TenNCC" DataValueField="MaNCC">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
        SelectCommand="SELECT * FROM [NhaCungCap]"></asp:SqlDataSource>
</div>
<div>
    <asp:Label ID="Label8" runat="server" Text="Mã Vật Liệu"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Tìm" />
</div>
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="MaVL" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="MaVL" HeaderText="MaVL" InsertVisible="False" 
                ReadOnly="True" SortExpression="MaVL" />
            <asp:BoundField DataField="TenVL" HeaderText="TenVL" SortExpression="TenVL" />
            <asp:BoundField DataField="MaVL" HeaderText="Số lượng thực" 
                InsertVisible="False" ReadOnly="True" SortExpression="MaVL" />
            <asp:BoundField DataField="MaVL" HeaderText="Số lượng giao" 
                InsertVisible="False" ReadOnly="True" SortExpression="MaVL" />
            <asp:HyperLinkField HeaderText="Xử lý nhập" Text="Lưu" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
        SelectCommand="SELECT [MaVL], [TenVL] FROM [VatLieu] WHERE (([MaNCC] = @MaNCC) AND ([MaVL] = @MaVL))">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="MaNCC" Type="Int32" />
            <asp:Parameter DefaultValue="4" Name="MaVL" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
<div>
    <asp:Label ID="Label6" runat="server" Text="CHI TIẾT PHIẾU NHẬP"></asp:Label>  
</div>
<div>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="MaVL" DataSourceID="SqlDataSource3">
        <Columns>
            <asp:BoundField HeaderText="MaVL" DataField="MaVL" InsertVisible="False" 
                ReadOnly="True" SortExpression="MaVL" />
            <asp:BoundField DataField="TenVL" HeaderText="TenVL" SortExpression="TenVL" />
            <asp:TemplateField HeaderText="Số lượng thực" InsertVisible="False" 
                SortExpression="MaVL">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaVL") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaVL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="MaVL" HeaderText="Số lượng giao" 
                InsertVisible="False" ReadOnly="True" SortExpression="MaVL" />
            <asp:HyperLinkField HeaderText="Bỏ chọn" Text="Xóa" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
        SelectCommand="SELECT [MaVL], [TenVL] FROM [VatLieu]"></asp:SqlDataSource>
</div>
<div>
    <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" Text="Lưu" />
        <input type="reset" value="HỦY" />
    </div>
</div>
</asp:Content>

