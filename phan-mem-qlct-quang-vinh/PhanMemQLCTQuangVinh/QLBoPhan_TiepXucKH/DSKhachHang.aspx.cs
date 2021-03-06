﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.Control;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using System.Text.RegularExpressions;

namespace PhanMemQLCTQuangVinh.QLBoPhan_TiepXucKH
{
    public partial class DSKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DTOKhachHang dto = new DTOKhachHang();
                DAO_Entity daokh = new DAO_Entity();

                XuLy_TiepNhanDonHang control = new XuLy_TiepNhanDonHang();
                control.LayDSKhachHang();

                List<DTOKhachHang> Dskh = daokh.TaoDSKH();
                GridDSKH.DataSource = Dskh;
                GridDSKH.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }
            ThemKH.Visible = false;


            if (IsPostBack == false)
            {
                List<DTOLoaiKH> dsLKH = new List<DTOLoaiKH>();
                DAO_Entity daoKH = new DAO_Entity();
                dsLKH = daoKH.LayDSLKH();
                //hien thi ten loai KH ra dropdownlist
                ddLoaiKH.DataTextField = "TenLKH";//TenLKH la thuoc tinh trong DTOLoaiKH
                //truyen dl theo ma loai 
                ddLoaiKH.DataValueField = "MaLKH";//MaLKH la thuoc tinh trong DTOLoaiKH
                ddLoaiKH.DataSource = dsLKH;
                ddLoaiKH.DataBind();
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            DAO_Entity daoKH = new DAO_Entity();

            XuLy_TiepNhanDonHang control = new XuLy_TiepNhanDonHang();
            control.TimtenKH(txtTim.Text.Trim());

            List<DTOKhachHang> kqTim = daoKH.TimTheoTenKH(txtTim.Text.Trim());
            GridDSKH.DataSource = kqTim;
            GridDSKH.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            ThemKH.Visible = true;

        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            DTOKhachHang dtoKH = new DTOKhachHang();

            dtoKH.TenKH = txtTenKH.Text;
            dtoKH.DiaChiKH = txtDiaChi.Text;
            dtoKH.SdtKH = txtSdt.Text;

            DTOLoaiKH dtoLoaiKH = new DTOLoaiKH();
            dtoLoaiKH.MaLKH = int.Parse(ddLoaiKH.SelectedValue);
            dtoLoaiKH.TenLKH = ddLoaiKH.SelectedItem.ToString();
            dtoKH.dtoLoaiKH = dtoLoaiKH;

            XuLy_TiepNhanDonHang control = new XuLy_TiepNhanDonHang();
    //        DAO_Entity daoKH = new DAO_Entity();
            if (KiemTraNhap() == "")
            {
                control.ThemKH(dtoKH);
                Response.Redirect("~/QLBoPhan_TiepXucKH/DSKhachHang.aspx");
            }
            else
            {
                ThemKH.Visible = true;
                lbLoi.Text = KiemTraNhap();
            }
        }
        private string KiemTraNhap()
        {
            string kq = "";
            if (txtTenKH.Text.Trim() == "")
            {
                kq += "Vui lòng nhập tên!";
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                kq += "<br>Vui lòng nhập địa chỉ!";
            }
            if (txtSdt.Text.Trim()== "")
            {
                kq += "<br>Vui lòng nhập Số Điện Thoại!";
            }
            return kq;
        }

        

    }
}