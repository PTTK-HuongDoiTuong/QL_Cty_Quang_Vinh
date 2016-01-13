<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="XuatNguyenVatLieu.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.XuatNguyenVatLieu.XuatNguyenVatLieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
<h2>XUẤT NGUYÊN VẬT LIỆU SẢN XUẤT</h2>
<div>
 <div class="text-center"><strong>CHI TIẾT PHIẾU ĐẶT</strong></div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Mã Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>
    <div>
    <div class="text-center"><strong>THÔNG TIN KHO VẬT LIỆU</strong></div>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Mã Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên Vật Liệu" />
            <asp:TemplateField HeaderText="Số lượng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đặt Vật Liệu">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" Text="Đặt"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>
</div>
<div>
<div class="text-center"> <strong>PHIẾU XUẤT KHO</strong></div>
    <asp:Label ID="Label4" runat="server" Text="Ngày nhập :"></asp:Label>
    <asp:Label ID="lbdate" runat="server" Text=""></asp:Label>
</div>
<div>
    <asp:Label ID="Label8" runat="server" Text="Mã Nhân Viên"></asp:Label>
    <asp:TextBox ID="txtmanv" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label6" runat="server" Text="Mã Vật Liệu"></asp:Label>
    <asp:TextBox ID="txtmavl" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Label ID="Label5" runat="server" Text="Số lượng"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</div>
<div>
    <asp:Button ID="bt_them" runat="server" Text="Thêm" />
</div>
<div>
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Mã Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Vật Liệu">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
<div>
    <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" onclick="btnLuu_Click" Text="Lưu" />
        <input type="reset" value="HỦY" />
    </div>
</div>
</asp:Content>
