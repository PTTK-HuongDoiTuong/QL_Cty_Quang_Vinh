using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;
using System.Data;

namespace PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.QLCongNoNCC
{
    public partial class DanhSachCongNo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DAO_Entity daokh = new DAO_Entity();
                List<DTOPhieuDatVatLieuCC> dsdh = daokh.LayDSCongNoNCC();
                GridView1.DataSource = dsdh;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }
        }
    }
}