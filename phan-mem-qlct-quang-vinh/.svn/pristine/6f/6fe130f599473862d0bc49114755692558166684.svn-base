using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;

namespace PhanMemQLCTQuangVinh
{
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DAO_Entity daokh = new DAO_Entity();
                List<DTOKhachHang> dsKH = daokh.TaoDSKH();
                GridKH.DataSource = dsKH;
                GridKH.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }
        }

        protected void GridDSKH_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdXoa")
            {
                LinkButton btnXoa = (LinkButton)e.CommandSource;
                string MaKH = btnXoa.CommandArgument;
                DAO_Entity daoKH = new DAO_Entity();
                if (daoKH.XoaKhachHang(int.Parse(MaKH)) == true)
                {
                    Response.Redirect("~/QLKhachHang/KhachHang.aspx");
                }
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            DAO_Entity dao = new DAO_Entity();
            string tendetim = txtTimTen.Text;
            List<DTOKhachHang> kqTim = dao.TimTheoTenKH(tendetim);
            GridKH.DataSource = kqTim;
            GridKH.DataBind();
        }

    }
}