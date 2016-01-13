<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTietDH.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_TiepXucKH.ChiTietDH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Chi TiẾt Đơn Hàng</h2>
    <div class="form-content">
        <div class="form-item">
            <asp:Label ID="lbmact" runat="server" Text="Mã Đơn Hàng:  "></asp:Label>
            <asp:Label ID="lbMadh" runat="server" Text=""></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="Label7" runat="server" Text="Mã khách hàng:"></asp:Label>
            <asp:Label ID="lbMaKH" runat="server" Text=""></asp:Label>
        </div>
        <div class="form-item">
            <asp:Label ID="lbma" runat="server" Text="Tên khách hàng: "></asp:Label>
            <asp:Label ID="tenKH" runat="server" Text="Label"></asp:Label>
        </div>
        
    </div>

    <h3>
        Danh sách sản phẩm
    </h3>

    <asp:Button ID="btnTaiLai" runat="server" Text="Tải lại" />

    
    <asp:Label ID="lbDSChon" runat="server" Text="Danh sách sản phẩm đã chọn" CssClass="label-text"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:TemplateField HeaderText="Mã ĐH">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("MaDH") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaDH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MaSP">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("dtoSP.MaSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("dtoSP.MaSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên SP">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("dtoSP.TenSP") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("dtoSP.TenSP") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giá SP">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("dtoSP.Gia") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("dtoSP.Gia") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số Lượng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("SoLuong") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("SoLuong") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Thành Tiền">
                <EditItemTemplate>
                    <asp:TextBox ID="ThanhTien" runat="server" Text='<%# Bind("ThanhTien") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("ThanhTien") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="form-item form-inline">
        <asp:Label ID="lbSumSP" runat="server" Text="Tổng Sản Phẩm:"></asp:Label>
        <asp:Label ID="lbTongSP" runat="server" Text=""></asp:Label>
    </div>
    
    <div class="form-item form-inline">
        <asp:Label ID="lbTong" runat="server" Text="Tổng Tiền: "></asp:Label>
        <asp:Label ID="lbTongTien" runat="server" Text="0"></asp:Label>
    </div>

    <div class="form-action">
        <asp:Button ID="btLuuCt" runat="server" Text="Lưu" onclick="btLuuCt_Click" />
        <asp:Button ID="btQuayVe" runat="server" onclick="btQuayVe_Click" Text="Quay Về" />
    </div>    
    
</asp:Content>
