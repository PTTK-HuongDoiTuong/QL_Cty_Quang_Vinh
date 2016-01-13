<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DSDH_(Dangxuly).aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_SanXuat.XuatTPchoThuKhoTP.DSDH__Dangxuly_" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
                <h2>DANH SÁCH ĐƠN HÀNG ĐANG XỬ LÝ</h2>
 <div>
 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
         DataKeyNames="MaDH" DataSourceID="SqlDataSource1">
     <Columns>
         <asp:BoundField DataField="MaDH" HeaderText="MaDH" InsertVisible="False" 
             ReadOnly="True" SortExpression="MaDH" />
         <asp:BoundField DataField="NgayTaoDH" HeaderText="NgayTaoDH" 
             SortExpression="NgayTaoDH" />
         <asp:BoundField DataField="TrangThai" HeaderText="TrangThai" 
             SortExpression="TrangThai" />
         <asp:TemplateField HeaderText="Xử lý xuất ">
             <ItemTemplate>
                 <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" Text="Xuất"></asp:HyperLink>
             </ItemTemplate>
         </asp:TemplateField>
     </Columns>
    </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
         ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
         SelectCommand="SELECT [MaDH], [NgayTaoDH], [TrangThai] FROM [DonDH] WHERE ([TrangThai] = @TrangThai)">
         <SelectParameters>
             <asp:Parameter DefaultValue="Đang Xử Lý" Name="TrangThai" Type="String" />
         </SelectParameters>
     </asp:SqlDataSource>
 </div>
    

</asp:Content>
