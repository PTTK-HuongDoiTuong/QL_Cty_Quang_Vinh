using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;

namespace PhanMemQLCTQuangVinh.QLCauHinhTrangThai
{
    public partial class TrangThai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThemTT.Visible = false;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ThemTT.Visible = true;
            // Response.Redirect("~/QLCauHinhTrangThai/ThemTrangThai.aspx");
        }

        protected void btnLuuTT_Click(object sender, EventArgs e)
        {
            

            DTOTrangThai dtott = new DTOTrangThai();
            dtott.TenTT = txtTenTT.Text;

            DAO_Entity daott = new DAO_Entity();

            if (KiemTraNhap() == "")
            {
                daott.ThemTT(dtott);
                Response.Redirect("~/QLBophan_Admin/QLCauHinhTrangThai/TrangThai.aspx");
            }
            else
            {
                ThemTT.Visible = true;
                lbLoi.Text = KiemTraNhap();
            }

        }

        private string KiemTraNhap()
        {
            string kq = "";
            DAO_Entity daoKH = new DAO_Entity();
            if (txtTenTT.Text.Trim() == "")
            {
                kq += "Vui lòng nhập tên!";
            }
            return kq;
        }
        
    }
}