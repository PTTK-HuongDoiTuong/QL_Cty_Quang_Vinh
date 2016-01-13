﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.Control;


namespace PhanMemQLCTQuangVinh.QLBoPhan_TiepXucKH
{
    public partial class ChiTietDH : System.Web.UI.Page
    {
        
        DAO_Entity daoEntities = new DAO_Entity();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                string madh = Request.QueryString["MaDH"].ToString();
                List<DTOChiTietDH> dsCTDH = daoEntities.LayDSChiTietDH(madh);

                //XuLy_TiepNhanDonHang control = new XuLy_TiepNhanDonHang();
                //control.laychitietdh(madh);

                GridView1.DataSource = dsCTDH;
                GridView1.DataBind();
                int tongtien = 0;
                foreach (DTOChiTietDH dtoChiTiet in dsCTDH)
                {
                    tongtien += dtoChiTiet.ThanhTien;
                }
                lbTongTien.Text = tongtien.ToString();
                lbTongSP.Text = dsCTDH.Count.ToString();
            }
            catch
            {
                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }
           
            if (IsPostBack == false)
            {               
                string maDH = Request.QueryString["MaDH"].ToString();

             
                DTODonDatHang dtoDH = daoEntities.LayDHTheoMa(maDH);
                lbMadh.Text = dtoDH.MaDH.ToString();
                lbMaKH.Text = dtoDH.MaKH.ToString();
                tenKH.Text = dtoDH.TenKH.ToString();
                if (GridView1.Rows.Count != 0 && dtoDH.TongTien != 0)
                {                    
                    btLuuCt.Visible = false;
                }
                else
                {
                    //lbTong.Visible = false;
                    //txtTongtien.Visible = false;
                    
                    btLuuCt.Visible = true;
                }
                
                int sum = GridView1.Rows.Count;

            }

        }

        

        
        protected void btLuuCt_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(lbMadh.Text);
            DAO_Entity daokh = new DAO_Entity();
            DTODonDatHang dtodh = new DTODonDatHang();
            DTOChiTietDonHang dtoct = daokh.LayTongTien(ma);
            
            dtodh.TongTien = int.Parse(dtoct.ThanhTien.ToString());
            dtodh.CongNoDH = dtodh.TongTien;
            daokh.CapNhatTongTien(dtodh);
            
            Response.Redirect("~/QLBoPhan_TiepXucKH/TaoDonHang.aspx?MaKH="+lbMaKH.Text);

        }

        protected void btQuayVe_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QLBoPhan_TiepXucKH/TaoDonHang.aspx?MaKH=" + lbMaKH.Text);
        }

       

        

        

        

    }
}