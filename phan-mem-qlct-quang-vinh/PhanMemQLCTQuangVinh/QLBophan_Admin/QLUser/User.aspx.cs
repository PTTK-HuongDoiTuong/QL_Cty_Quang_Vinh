using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;
using System.Data;

namespace PhanMemQLCTQuangVinh.QLUser
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ThemUser.Visible = false;   
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ThemUser.Visible = true;
            //Response.Redirect("~/QLUser/ThemUser.aspx");

            if (IsPostBack == false)
            {
                List<DTONhomQuyen> dsnq = new List<DTONhomQuyen>();
                DAO_Entity daond = new DAO_Entity();
              //  dsnq = daond.LayDSNhomQuyen();

                ddlNhomQ.DataTextField = "NhomQuyen";

                ddlNhomQ.DataValueField = "MaNhomQ";
                ddlNhomQ.DataSource = dsnq;
                ddlNhomQ.DataBind();
            }

        }
        
        protected void btnLuuUser_Click(object sender, EventArgs e)
        {
            DTOUser dtond = new DTOUser();

            dtond.ID = txtID.Text;
            dtond.MK = txtMK.Text;
            dtond.HTuser = txtHoTen.Text;

            DTONhomQuyen dtonq = new DTONhomQuyen();
            dtonq.MaNQ = int.Parse(ddlNhomQ.SelectedValue);
            dtonq.NhomQ = ddlNhomQ.SelectedItem.ToString();
            dtond.dtoNhomQ = dtonq;

            DAO_Entity daond = new DAO_Entity();
            if (KiemTraNhap() == "")
            {
                daond.ThemUser(dtond);
                Response.Redirect("~/QLBophan_Admin/QLUser/User.aspx");
            }
            else
            {
                ThemUser.Visible = true;
                lbLoi.Text = KiemTraNhap();
            }
        }
        private string KiemTraNhap()
        {
            string kq = "";
            DAO_Entity daoKH = new DAO_Entity();
            if (txtID.Text.Trim() == "")
            {
                kq += "Vui lòng nhập ID!";
            }
            if (txtMK.Text.Trim() == "")
            {
                kq += "<br>Vui lòng nhập Mật Khẩu!";
            }
            if (txtHoTen.Text.Trim() == "")
            {
                kq += "Vui lòng nhập Họ Tên!";
            }
            return kq;
        }
    }
    
}