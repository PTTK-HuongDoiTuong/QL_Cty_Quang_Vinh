using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;

namespace PhanMemQLCTQuangVinh.QLCauHinhLoaiKH
{
    public partial class LoaiKH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*try
            {
               //DAOLoaiKH daolkh = new DAOLoaiKH();
               // List<DTOLoaiKH> dslkh = daolkh.TaoDSLKH();
               // GridDSLKH.DataSource = dslkh;
               // GridDSLKH.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }*/

            ThemLoaiKH.Visible = false;
            
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiKH.Visible = true;
            //Response.Redirect("~/QLCauHinhLoaiKH/ThemLoaiKH.aspx");
        }

        protected void btnLuuKH_Click(object sender, EventArgs e)
        {
            DTOLoaiKH dtoLKH = new DTOLoaiKH();
            dtoLKH.TenLKH = txtTenLKH.Text;

            DAO_Entity daoLKH = new DAO_Entity();
            if (KiemTraNhap() == "")
            {
                daoLKH.ThemLoaiKH(dtoLKH);
                Response.Redirect("~/QLBophan_Admin/QLCauHinhLoaiKH/LoaiKH.aspx");
            }
            else
            {
                ThemLoaiKH.Visible = true;
                lbLoi.Text = KiemTraNhap();
            }

        }

        private string KiemTraNhap()
        {
            string kq = "";
            DAO_Entity daoKH = new DAO_Entity();
            if (txtTenLKH.Text.Trim() == "")
            {
                kq += "Vui lòng nhập tên!";
            }
            return kq;
        }
        

    }
}