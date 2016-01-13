<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TongHopDonHang.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_SanXuat.DatNuyenVatLieu_SX.TongHopDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>TỔNG HỢP ĐƠN HÀNG</h2>
    <div><asp:Label ID="lbNPDH" runat="server" Text="Ngày Phiếu Đặt Hàng"></asp:Label></div>
    <div class="search">
        <asp:TextBox ID="txtTim" runat="server" ></asp:TextBox>
        <asp:Button ID="btnTim" runat="server" Text="Tìm" Height="35px" Width="88px" />
    </div>
 <div>

        <asp:Label ID="LbDSDH" runat="server" Text="Danh Sách DH"></asp:Label>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" DataKeyNames="MaDH">
            <Columns>
                <asp:TemplateField HeaderText="MaDH" InsertVisible="False" 
                    SortExpression="MaDH">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaDH") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaDH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NgayTaoDH" SortExpression="NgayTaoDH">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("NgayTaoDH") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("NgayTaoDH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TrangThai" SortExpression="TrangThai">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TrangThai") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("TrangThai") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Chọn">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" Text="Chọn"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            SelectCommand="SELECT [MaDH], [NgayTaoDH], [TrangThai] FROM [DonDH] WHERE ([TrangThai] = @TrangThai)">
            <SelectParameters>
                <asp:Parameter DefaultValue="Chưa xử lý" Name="TrangThai" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    <div>
         <td><asp:Label ID="Label4" runat="server" Text="Danh sách tổng hợp phiếu đặt"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
             DataKeyNames="MaDH" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:TemplateField HeaderText="MaDH" InsertVisible="False" 
                    SortExpression="MaDH">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaDH") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("MaDH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NgayTaoDH" SortExpression="NgayTaoDH">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NgayTaoDH") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("NgayTaoDH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TrangThai" SortExpression="TrangThai">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TrangThai") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("TrangThai") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Bỏ chọn">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" Text="Chọn"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
             ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
             SelectCommand="SELECT [MaDH], [TrangThai], [NgayTaoDH] FROM [DonDH] WHERE ([TrangThai] = @TrangThai)">
             <SelectParameters>
                 <asp:Parameter DefaultValue="Đang xử lý" Name="TrangThai" Type="String" />
             </SelectParameters>
         </asp:SqlDataSource>
     </div>  
         <div>
         <asp:Button ID="Button1" runat="server" Text="TỔNG HỢP" />
         </div> 
    <div>
        <asp:Label ID="lbDanhSachVLcan" runat="server" Text="Danh Sách Vật Liệu cần"></asp:Label>
   </div>
   <div>
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="MaVL" DataSourceID="SqlDataSource3">
            <Columns>
                <asp:BoundField DataField="MaVL" HeaderText="MaVL" InsertVisible="False" 
                    ReadOnly="True" SortExpression="MaVL" />
                <asp:BoundField DataField="TenVL" HeaderText="TenVL" SortExpression="TenVL" />
                <asp:BoundField DataField="Soluong" HeaderText="Soluong" 
                    SortExpression="Soluong" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:CSDLQuangVinh %>" 
            SelectCommand="SELECT [MaVL], [TenVL], [Soluong] FROM [VatLieu]">
        </asp:SqlDataSource>
</div>
        <div class="form-action">
        <asp:HyperLink ID="HyperlinkXuatPDVL" runat="server" NavigateUrl="~/QLPhieuDatVLSX/ThemPDVL_SX.aspx">XUẤT PHIẾU ĐẶT VẬT LIỆU</asp:HyperLink></div>
</asp:Content>

