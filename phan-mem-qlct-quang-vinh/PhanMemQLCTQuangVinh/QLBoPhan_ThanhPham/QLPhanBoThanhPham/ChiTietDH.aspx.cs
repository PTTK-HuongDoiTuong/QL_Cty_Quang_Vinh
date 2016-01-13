﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.Control;


namespace PhanMemQLCTQuangVinh.QLBoPhan_ThanhPham.QLPhanBoThanhPham
{
    public partial class ChiTietDH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string maDH = Request.QueryString["MaDH"].ToString();

                Xuly_PhanboThanhPham control = new Xuly_PhanboThanhPham();
                control.LayDonHangTheoMa(maDH);

                DAO_Entity daoDH = new DAO_Entity();
                DTODonDatHang dtoDH = daoDH.LayDHTheoMa(maDH);
                lbMaDH.Text = dtoDH.MaDH.ToString();
                lbKH.Text = dtoDH.MaKH.ToString();
            }


            try
            {
                
                string madh = Request.QueryString["MaDH"].ToString();

                Xuly_PhanboThanhPham control = new Xuly_PhanboThanhPham();
                control.LayCTDH(madh);


                DAO_Entity daokh = new DAO_Entity();
                List<DTOChiTietDH> dtoct = daokh.LayDSChiTietDH(madh);
                GridView1.DataSource = dtoct;
                GridView1.DataBind();

                List<DTOXuLyPhieuGiao> dto = daokh.LayDSPhieuGiao(madh);
                GridView3.DataSource = dto;
                GridView3.DataBind();

                control.LayDSkhosp();

                List<DTOKhoSP> dtok = daokh.LayDSKhoSP();
                GridView2.DataSource = dtok;
                GridView2.DataBind();

            }
            catch
            {
                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }
           
        }

        protected void btnThemSP_Click(object sender, EventArgs e)
        {


            XemDSKho.Visible = true;
            DTOXuLyPhieuGiao dtoct = new DTOXuLyPhieuGiao();
            // DTODonDatHang dtoDH = new DTODonDatHang();

            dtoct.MaDH = lbMaDH.Text;
            DTOSanPham dtoSP = new DTOSanPham();
            dtoct.MaSP = int.Parse(ddTP.SelectedValue);
            // dtoSP.TenSP = ddTP.SelectedItem.ToString();

            //dtoct.dtoSP = dtoSP;
            //dtoct.dtoDH = dtoDH;

            //dtoSP.TenSP = ddTP.SelectedValue;
            dtoct.SoLuong = int.Parse(txtSoLuong.Text);

            dtoct.ThanhTien = int.Parse(lbgia.Text) * int.Parse(txtSoLuong.Text);


            //BLLXuLyDonHang bll = new BLLXuLyDonHang();
            //bll.ThemChiTietDH(dtoct);


            DTOKhoSP dtokho = new DTOKhoSP();
            dtokho.MaSP = int.Parse(ddTP.SelectedValue);
            dtokho.Soluong = int.Parse(lbSLKho.Text) - int.Parse(txtSoLuong.Text);
            DAO_Entity dao = new DAO_Entity();
            dao.CapNhatSLKhoSP(dtokho);

          


            DAO_Entity daokh = new DAO_Entity();
            daokh.ThemPhieuGiaoHang(dtoct);
            Response.Redirect(Request.RawUrl);

        }

        protected void ddTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            XemDSKho.Visible = true;
            int masp = int.Parse(ddTP.SelectedValue);
            DAO_Entity daoKH = new DAO_Entity();
            DTOSanPhamCT dtosp = daoKH.LayGiaSPTheoMaCT(masp);
            lbgia.Text = dtosp.Gia.ToString();

            int ma = int.Parse(ddTP.SelectedValue);
            DAO_Entity dao = new DAO_Entity();
            DTOKhoSP dto = dao.LaySoLuongKhoSP(ma);
            lbSLKho.Text = dto.Soluong.ToString();
        }

        protected void btnXuat_Click(object sender, EventArgs e)
        {
            //string ma = txtMaDH.Text;
            //DAO_Entity dao = new DAO_Entity();

            //DTOXuLyPhieuGiao dtopg = new DTOXuLyPhieuGiao();
            ////DTOChiTietDonHang dtodh = dao.LayTongTienGiaoHang(ma);

            Response.Redirect("~/QLBoPhan_ThanhPham/QLPhanBoThanhPham/PhanBoThanhPham.aspx?MaDH=" +lbMaDH.Text);
        }
    }
}