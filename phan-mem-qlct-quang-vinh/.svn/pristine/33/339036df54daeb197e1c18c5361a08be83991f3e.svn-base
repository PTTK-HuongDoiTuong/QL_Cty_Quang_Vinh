<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="XuatThanhPham_BPSX.aspx.cs" Inherits="PhanMemQLCTQuangVinh.QLBoPhan_SanXuat.XuatTPchoThuKhoTP.XuatThanhPham_BPSX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>XUẤT THÀNH PHẨM SẢN XUẤT</h2>
    <div>
    <h3 class="text-left">CHI TIẾT ĐƠN HÀNG</h3>
    </div>

     <div>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
             Width="1135px">
             <Columns>
                 <asp:TemplateField HeaderText="Mã Thành Phẩm">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label2" runat="server"></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Tên Thành Phẩm">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server"></asp:Label>
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
                 <asp:TemplateField HeaderText="Số lượng thiếu">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server"></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
         </asp:GridView>
    </div>

     <div>
     <h3 class="text-left">CHI TIẾT PHIẾU XUẤT</h3>
    </div>

     <div>
         <asp:Label ID="Label1" runat="server" Text="Mã đơn hàng:"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="lbMDH" runat="server" Text=""></asp:Label>
    </div>

     <div>
         <asp:Label ID="Label3" runat="server" Text="Ngày Lập: "></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="lbNL" runat="server" Text=""></asp:Label>
    </div>

     <div>
         <asp:Label ID="Label5" runat="server" Text="Mã Thành Phẩm:"></asp:Label>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>

     <div>
         <asp:Label ID="Label6" runat="server" Text="Số lượng: "></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>

     <div>
         <div>
         </div>
         <asp:Button ID="Button1" runat="server" Text="THÊM" Height="37px" 
             Width="81px" />
    </div>

     <div>
         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
             Width="1149px">
             <Columns>
                 <asp:TemplateField HeaderText="Mã Thành Phẩm">
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                     </EditItemTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server"></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Tên Thành Phẩm">
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

     <div class="form-item form-action">
        <asp:Button ID="btnLuu" runat="server" onclick="btnLuu_Click" Text="Lưu" />
        <input type="reset" value="HỦY" />
    </div>      
</asp:Content>
