<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TaoDonHang.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_TiepXucKH.TaoDonHang" %>
<%--<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Tạo ĐƠN HÀNG</h2>
    <div class="form-content">
        <div class="form-item">
            <asp:Label ID="lbMa" runat="server" Text="Mã khách hàng: " AssociatedControlID="lbMaKH"></asp:Label>
            <asp:Label ID="lbMaKH" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="lbTen" runat="server" Text="Tên khách hàng: " AssociatedControlID="txtTen"></asp:Label>
            <asp:TextBox ID="txtTen" runat="server" ></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="lbNgayTao" runat="server" Text="Ngày tạo: " AssociatedControlID="txtNgayTaoDH"></asp:Label>
            <asp:TextBox ID="txtNgayTaoDH" runat="server"></asp:TextBox>      
        </div>
        <div class="form-item">
            <asp:Label ID="lbNgayGiao" runat="server" Text="Ngày Giao: " AssociatedControlID="txtGiao"></asp:Label>
            <asp:TextBox ID="txtGiao" runat="server"></asp:TextBox>
        </div>
        <div class="form-action">
            <asp:Button ID="btnThemDh" runat="server" onclick="btnThemDh_Click" 
                Text="Thêm Đơn Hàng Mới" />
        </div>
    </div>

    <h3>
        Danh sách đơn hàng
    </h3>        
    <asp:GridView ID="GridViewDH" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" onpageindexchanging="GridViewDH_PageIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="Mã ĐH">
                <EditItemTemplate>
                    <asp:TextBox ID="txtmadh" runat="server" Text='<%# Bind("MaDH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaDH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="MaKH" HeaderText="Mã KH" />
            <asp:BoundField DataField="TenKH" HeaderText="Tên KH" />
            <asp:BoundField DataField="NgayTaoDH" HeaderText="Ngày Đặt" 
                DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="NgayGH" HeaderText="Ngày Giao" 
                DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền ĐH" />
            <asp:BoundField DataField="CongNoDH" HeaderText="Tiền Phải Trả" />
            <asp:BoundField DataField="TrangThai" HeaderText="Trạng Thái" />
            <asp:TemplateField HeaderText="Chi Tiết ĐH">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='<%# "~/QLBoPhan_TiepXucKH/ChiTietDH.aspx?MaDH=" + Eval("MaDH") %>' 
                        Text="Chi Tiết ĐH"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đặt Cọc">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink2" runat="server" 
                        NavigateUrl='<%# "~/QLBoPhan_TiepXucKH/DatCoc.aspx?MaDH=" + Eval("MaDH") %>' 
                        Text="Đặt Cọc"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <h3>
        <asp:Label ID="lbDSSanpham" runat="server" Text="Danh sách sản phẩm"></asp:Label>
    </h3>
    <asp:GridView ID="grDSSanPham" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" 
        onrowcommand="grDSSanPham_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Mã sản phẩm">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("maSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("maSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên sản phẩm">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("TenSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbTenSP" runat="server" Text='<%# Bind("TenSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giá">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Gia") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbGia" runat="server" Text='<%# Bind("Gia") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Loại">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" 
                        Text='<%# Bind("dtoLoaiSP.TenLSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("dtoLoaiSP.TenLSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    <asp:TextBox ID="txtSLThuc" runat="server" Text=""></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False" HeaderText="Thêm sản phẩm">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                        CommandName="themThanhPham" CommandArgument='<%# Eval("MaSP") %>' Text="Thêm"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <h3>
        <asp:Label ID="lbDSChon" runat="server" Text="Sản phẩm đã chọn"></asp:Label>
    </h3>
    <asp:GridView ID="gridDSChon" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" 
        onrowcommand="gridDSChon_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Mã sản phẩm">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("dtoSP.MaSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbMaSP" runat="server" Text='<%# Bind("dtoSP.MaSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên sản phẩm">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("dtoSP.TenSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("dtoSP.TenSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giá">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("dtoSP.Gia") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("dtoSP.Gia") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox9" runat="server" 
                        Text='<%# Bind("soluong") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbSoluong" runat="server" Text='<%# Bind("SoLuong") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xóa" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton OnClientClick="return confirm('Bạn có muốn xóa thành phẩm này khỏi danh sách?');" ID="LinkButton1" runat="server" CausesValidation="false" 
                        CommandName="xoaThanhPhamChon" CommandArgument='<%# Eval("dtoSP.maSP") %>' Text="Xóa"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thành tiền">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ThanhTien") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbThanhTien" runat="server" Text='<%# Bind("ThanhTien") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <asp:Label ID="lbTextTongTien" runat="server" Text="Tổng tiền: "></asp:Label>
        <asp:Label ID="lbTongTien" runat="server" Text="0"></asp:Label>
    </div>
    <div class="form-action">
        <asp:Button ID="btnLuu" runat="server" Text="Lưu" onclick="btnLuu_Click" />
        <asp:Button ID="btbQuayLai" runat="server" onclick="Button1_Click" 
            Text="Quay Về" />
        <br />
    </div>
</asp:Content>
