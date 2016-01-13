using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhanMemQLCTQuangVinh
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((bool)Session["DaDangNhap"] == false)
            //{
            //    Label lblchao = new Label();
            //    lblchao.Text = "Chào Bạn   ";
                

            //    HyperLink hblDangNhap = new HyperLink();
            //    hblDangNhap.Text = "Đăng Nhập";
            //    hblDangNhap.NavigateUrl = "~/GUI/DangNhap.aspx";

            //    tdChao.Controls.Add(lblchao);
            //    tdChao.Controls.Add(hblDangNhap); 
            //}
            //else
            //{
            //    Label lblchao = new Label();
            //    lblchao.Text = "Chào:  " + Session["HoTen"] + "  ";

            //    HyperLink hblDoiMK = new HyperLink();
            //    hblDoiMK.Text = "Đổi Mật Khẩu  ";
            //    hblDoiMK.NavigateUrl = "~/GUI/DoiMatKhau.aspx";

            //    LinkButton lbtThoat = new LinkButton();
            //    lbtThoat.Text = "Thoát";
            //    lbtThoat.Click += new  EventHandler(lbtThoat_Click);

            //    tdChao.Controls.Add(lblchao);
            //    tdChao.Controls.Add(hblDoiMK);
            //    tdChao.Controls.Add(lbtThoat);              
                
            //}
        }
        protected void lbtThoat_Click(object sender, EventArgs e)
        {
            Session["DaDangNhap"] = false;
            Response.Redirect(Request.RawUrl);
 
        }
        }
    }
