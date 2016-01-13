using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.Control;

namespace PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QLPhieuNhapTP
{
    public partial class DSDonHang_DangXL_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsPostBack == false)
                {

                    XuLy_NhapTP control = new XuLy_NhapTP();
                    control.LayDHdangXL();

                    DAO_Entity entities = new DAO_Entity();
                    gridDSDonHang.DataSource = entities.LayDSDonHangDangXuLy();
                    gridDSDonHang.DataBind();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}