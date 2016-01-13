using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;
using System.Data;

namespace PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QuanLyQuanNo_BH
{
    public partial class ThanhToan_BH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string maDH = Request.QueryString["MaDH"].ToString();
                DAO_Entity daoDH = new DAO_Entity();
                DTODonDatHang dtoDH = daoDH.LayDHTheoMa(maDH);
                lbMaDH.Text = dtoDH.MaDH.ToString();
                lbMaKH.Text = dtoDH.MaKH.ToString();
                lbTenKH.Text = dtoDH.TenKH.ToString();
                lbTienTra.Text = dtoDH.CongNoDH.ToString();
                lbNgayTra.Text = DateTime.Now.ToShortDateString();
            }


        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            DTOCongNoBanHang dto = new DTOCongNoBanHang();
            dto.MaDH = lbMaDH.Text;
            dto.MaKH = int.Parse(lbMaKH.Text);
            dto.MaNV = int.Parse(txtMaNV.Text);
            dto.NgayTraNo = Convert.ToDateTime(lbNgayTra.Text);
            dto.TienTT = int.Parse(txtTienTT.Text);

            DAO_Entity dao = new DAO_Entity();
            dao.ThemCongNoBH(dto);

            DTODonDatHang dtodh = new DTODonDatHang();
            dtodh.MaDH = lbMaDH.Text;
            int tong = int.Parse(lbTienTra.Text);
            int no = int.Parse(txtTienTT.Text);
            dtodh.CongNoDH = tong - no;
            dao.CapNhatCongNo(dtodh);

            if (dtodh.CongNoDH == 0)
            {
                dao.CapNhatTrangThaisauThanhToan(dtodh);
            }

            Response.Redirect("~/QLBoPhan_ThanhPham/QuanLyQuanNo_BH/DanhSachCongNo_BH.aspx");
        }
    }
}