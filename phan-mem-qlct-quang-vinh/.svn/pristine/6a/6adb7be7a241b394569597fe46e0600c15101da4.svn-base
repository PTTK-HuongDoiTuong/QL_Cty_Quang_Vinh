using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;

namespace PhanMemQLCTQuangVinh.QLCauHinhNCC
{
    public partial class NCC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThemNCC.Visible = false;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ThemNCC.Visible = true;
            //Response.Redirect("~/QLCauHinhNCC/ThemNCC.aspx");
        }


        private string KiemTraNhap()
        {
            string kq = "";
            DAO_Entity daoKH = new DAO_Entity();
            if (txtTen.Text.Trim() == "")
            {
                kq += "Vui lòng nhập tên!";
            }
            if (txtSDT.Text.Trim() == "")
            {
                kq += "Vui Lòng nhập SDT!";
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                kq += "Vui Lòng nhập địa chỉ!";
            }
            return kq;
        }

        protected void btnLu_Click(object sender, EventArgs e)
        {
            
            DTONhacungcap dtoncc = new DTONhacungcap();
            dtoncc.TenNCC = txtTen.Text;
            dtoncc.Sdt = txtSDT.Text;
            dtoncc.Diachi = txtDiaChi.Text;

            DAO_Entity daoncc = new DAO_Entity();
             if (KiemTraNhap() == "")
            {
                daoncc.ThemNhaCungCap(dtoncc);
                Response.Redirect("~/QLBophan_Admin/QLCauHinhNCC/NCC.aspx");
            }
            else
            {
                ThemNCC.Visible = true;
                lbLoi.Text = KiemTraNhap();
            }
        }
        }
    }