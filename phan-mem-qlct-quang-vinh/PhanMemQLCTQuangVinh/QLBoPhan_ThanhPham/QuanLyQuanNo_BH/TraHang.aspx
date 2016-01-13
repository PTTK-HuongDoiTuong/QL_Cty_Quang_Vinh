<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TraHang.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QuanLyQuanNo_BH.TraHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        PHIẾU Trả Hàng</h2>
    <div class="form-item">
        <asp:Label ID="Label1" runat="server" Text="Mã Đơn Hàng: " AssociatedControlID="lbMaDH"></asp:Label>
        <asp:Label ID="lbMaDH" runat="server"></asp:Label>
    </div>
    <div class="form-item">
        <asp:Label ID="Label2" runat="server" Text="Mã Khách Hàng: " AssociatedControlID="lbMaKH"></asp:Label>
        <asp:Label ID="lbMaKH" runat="server"></asp:Label>        
    </div>
    <div class="form-item">
        <asp:Label ID="Label5" runat="server" Text="Tên Khách Hàng: " AssociatedControlID="lbTenKH"></asp:Label>
        <asp:Label ID="lbTenKH" runat="server"></asp:Label>
    </div>
    <div class="form-item">
        <asp:Label ID="Label7" runat="server" Text="Mã Nhân Viên: " AssociatedControlID="txtMaNV"></asp:Label>
        <asp:TextBox ID="txtMaNV" runat="server"></asp:TextBox>
    </div>
        
    <div class="section">
        <h3>Chi tiết Đơn Hàng</h3>
        <asp:GridView ID="gridChiTietDonHang" runat="server" 
        AutoGenerateColumns="False" AllowPaging="True" 
        onpageindexchanging="gridChiTietDonHang_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã Sản Phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
                <asp:BoundField DataField="Gia" HeaderText="Giá" />
                <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng đã đặt" />
                <asp:BoundField DataField="ThanhTien" HeaderText="Thành Tiền" />
            </Columns>
        </asp:GridView>
    <span>Tổng tiền đã đặt: </span><asp:Label ID="lbTongTienDaDat" runat="server" Text="0"></asp:Label>
    </div>
        <h3>Danh sách thành phẩm có thể trả</h3>
        <asp:GridView ID="gridDSCanTra" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" onrowcommand="gridDSCanTra_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Mã sản phẩm">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("dtoSP.maSP") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbMaSP" runat="server" Text='<%# Bind("dtoSP.maSP") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên sảnp hẩm">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("dtoSP.tenSP") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbTenSP" runat="server" Text='<%# Bind("dtoSP.tenSP") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Giá">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("dtoSP.Gia") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbGia" runat="server" Text='<%# Bind("dtoSP.Gia") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Số lượng muốn trả">
                    <ItemTemplate>
                        <asp:TextBox ID="txtSoluong" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Thêm">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnThem" runat="server" CommandName="them" CommandArgument='<%# Eval("dtoSP.maSP") %>'>Thêm</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView> 
         
    <div class="section">
        <h3>Danh Sách Trả Hàng </h3>
            <asp:GridView ID="gridDSChon" runat="server" AutoGenerateColumns="False" 
            onrowcommand="gridDSChon_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="Mã Sản Phẩm" DataField="dtoSP.MaSP" />
                    <asp:BoundField HeaderText="Tên Sản Phẩm" DataField="dtoSP.TenSP" />
                    <asp:BoundField HeaderText="Giá" DataField="dtoSP.Gia" />
                    <asp:BoundField HeaderText="Số Lượng muốn trả" DataField="Soluong" />
                    <asp:BoundField HeaderText="Thành Tiền" DataField="ThanhTien" />
                    <asp:TemplateField HeaderText="Xóa">
                        <ItemTemplate>
                            <asp:LinkButton OnClientClick="return confirm('Bạn có muốn xóa?')" ID="btnXoa" runat="server" CommandName="xoa" CommandArgument='<%# Eval("dtoSP.maSP") %>'>Xóa</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        <div class="form-item">
            <asp:Label ID="Label11" runat="server" Text="Tổng Tiền: "></asp:Label>
            <asp:Label ID="lbTongTien" runat="server"></asp:Label>
        </div> 
    </div>
    <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" Text="Lưu" onclick="btnLuu_Click" />
    </div>
</asp:Content>
