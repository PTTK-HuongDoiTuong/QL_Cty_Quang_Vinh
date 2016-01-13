<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PhieuDatVatLieu.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_SanXuat.DatNuyenVatLieu_SX.PhieuDatVatLieu" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>PHIẾU ĐẶT VẬT LIỆU SẢN XUẤT</h2>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Ngày đặt: "></asp:Label>
        &nbsp;
        5/5/2015</div>

    <div>
        <asp:Label ID="Label3" runat="server" Text="Ngày giao: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MaVL" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="MaVL" HeaderText="MaVL" InsertVisible="False" 
                    ReadOnly="True" SortExpression="MaVL" />
                <asp:BoundField DataField="TenVL" HeaderText="TenVL" SortExpression="TenVL" />
                <asp:BoundField DataField="Soluong" HeaderText="Soluong" 
                    SortExpression="Soluong" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            SelectCommand="SELECT [MaVL], [TenVL], [Soluong] FROM [VatLieu]">
        </asp:SqlDataSource>
    </div>
    <div class="form-item form-action">
            <asp:Button ID="btnLuu" runat="server" Text="Lưu"  />
            <input type="reset" value="Huỷ" />
        </div>
</asp:Content>
