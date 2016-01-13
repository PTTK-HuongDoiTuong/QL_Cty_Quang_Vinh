using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;

namespace PhanMemQLCTQuangVinh.QLCauHinhLoaiSP
{
    public partial class LoaiSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThemLoaiSP.Visible = false;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiSP.Visible = true;
                    //Response.Redirect("~/QLCauHinhLoaiSP/ThemLoaiSP.aspx");
        }

        protected void btnLuuSP_Click(object sender, EventArgs e)
        {
            DTOLoaiSP dtoLSP = new DTOLoaiSP();
            dtoLSP.TenLSP = txtLSP.Text;

            DAO_Entity daoLSP = new DAO_Entity();
            if (KiemTraNhap() == "")
            {
                daoLSP.ThemLoaiSP(dtoLSP);
                Response.Redirect("~/QLBophan_Admin/QLCauHinhLoaiSP/LoaiSP.aspx");
            }
            else
            {
                ThemLoaiSP.Visible = true;
                lbLoi.Text = KiemTraNhap();
            }

        }

        private string KiemTraNhap()
        {
            string kq = "";
            DAO_Entity daoKH = new DAO_Entity();
            if (txtLSP.Text.Trim() == "")
            {
                kq += "Vui lòng nhập tên!";
            }
            return kq;
        }
        
    }
}