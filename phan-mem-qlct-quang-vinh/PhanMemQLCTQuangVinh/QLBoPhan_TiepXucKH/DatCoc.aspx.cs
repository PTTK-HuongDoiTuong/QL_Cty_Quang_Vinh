﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.Control;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQLCTQuangVinh.QLBoPhan_TiepXucKH
{
    public partial class DatCoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             if (IsPostBack == false)
             {
                 string maDH = Request.QueryString["MaDH"].ToString();
                 DAO_Entity daoDH = new DAO_Entity();
                 DTODonDatHang dtoDH = daoDH.LayDHTheoMa(maDH);
                 txtMaDH.Text = dtoDH.MaDH.ToString();
                 txtMaKH.Text = dtoDH.MaKH.ToString();
                 txtTenKH.Text = dtoDH.TenKH.ToString();
                 txtTong.Text = dtoDH.TongTien.ToString();
                 txtNgayThanhToan.Text = DateTime.Now.ToShortDateString();
             }
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QLBoPhan_TiepXucKH/TaoDonHang.aspx?MaKH=" + int.Parse(txtMaKH.Text));
        }

        protected void btbLuu_Click(object sender, EventArgs e)
        {
            DTOThanhToan dtocn = new DTOThanhToan();
            dtocn.MaDH = txtMaDH.Text;
            dtocn.MaNV = int.Parse(txtNhanVien.Text);
            dtocn.NgayThanhToan = Convert.ToDateTime(txtNgayThanhToan.Text);
            dtocn.Sotien = int.Parse(txtDatCoc.Text);
            dtocn.HanTT = Convert.ToDateTime(txtHanTT.Text);



            DAO_Entity daokh = new DAO_Entity();

            XuLy_TiepNhanDonHang control = new XuLy_TiepNhanDonHang();
            control.themdatcoc(dtocn);

            DTODonDatHang dtodh = new DTODonDatHang();
            dtodh.MaDH = txtMaDH.Text;
            int tong = int.Parse(txtTong.Text);
            int no = int.Parse(txtDatCoc.Text);
            dtodh.CongNoDH = tong - no;
            daokh.CapNhatCongNo(dtodh);


            Response.Redirect("~/QLBoPhan_TiepXucKH/TaoDonHang.aspx?MaKH=" + int.Parse(txtMaKH.Text));
        }

    }
}