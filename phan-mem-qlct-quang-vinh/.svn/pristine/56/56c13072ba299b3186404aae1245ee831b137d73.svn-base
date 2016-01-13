<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NhapVatLieu.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.NhapVatLieuNCC.NhapVatLieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>XỬ LÝ NHẬP VẬT LIỆU</h2>
    <div class="form-content">
        <div class="form-item">
            <asp:Label ID="Label1" runat="server" Text="Mã Phiếu Đặt" AssociatedControlID="MaPhieuDat"></asp:Label>
            <asp:Label ID="MaPhieuDat" runat="server" Text=""></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="Label4" runat="server" Text="Người giao" AssociatedControlID="txtNguoiGiao"></asp:Label>
            <asp:TextBox ID="txtNguoiGiao" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="Label2" runat="server" Text="Ngày giao" AssociatedControlID="txtNgayGiao"></asp:Label>
            <asp:TextBox ID="txtNgayGiao" runat="server"></asp:TextBox>
        </div>
        <div class="form-item">
            <asp:Label ID="Label3" runat="server" Text="Ngày nhập" AssociatedControlID="lbNgayNhap"></asp:Label>
            <asp:Label ID="lbNgayNhap" runat="server" Text="[NgayNhap]"></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="Label5" runat="server" Text="Mã Nhân Viên" AssociatedControlID="txtMaNV"></asp:Label>
            <asp:TextBox ID="txtMaNV" runat="server"></asp:TextBox>
        </div>
    </div>
<div class="form-search">
</div>
<div>
    <h3>
        Danh sách vật liệu bộ phận sản xuất đã đặt
    </h3>
    <asp:GridView ID="gridDSVatLieu" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Mã Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("dtoVatLieu.MaVL") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbMaVL" runat="server" Text='<%# Bind("dtoVatLieu.MaVL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("dtoVatLieu.TenVL") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("dtoVatLieu.TenVL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="dtoVatLieu.dtoNCC.TenNCC" 
                HeaderText="Nhà cung cấp" />
            <asp:TemplateField HeaderText="Số lượng thực">
                <ItemTemplate>
                    <asp:TextBox ID="txtSLThuc" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng giao">
                <ItemTemplate>
                    <asp:TextBox ID="txtSoluongGiao" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng không đạt">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbKhongDat" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>

<div>
    <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" Text="Lưu" onclick="btnLuu_Click" />
        <asp:Button ID="btnBack" runat="server" Text="Quay về" 
            onclick="btnBack_Click" />
    </div>
</div>
</asp:Content>

