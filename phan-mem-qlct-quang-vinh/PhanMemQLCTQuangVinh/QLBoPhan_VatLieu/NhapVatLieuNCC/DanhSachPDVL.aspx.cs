﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhanMemQLCTQuangVinh.DAO;
using PhanMemQLCTQuangVinh.DTO;

namespace PhanMemQLCTQuangVinh.QLBoPhan_VatLieu.NhapVatLieuNCC
{
    public partial class DanhSachPDVL : System.Web.UI.Page
    {
        DAO_Entity daoEntities = new DAO_Entity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<DTOPhieuDatVatLieuCC> dsPhieuDat = daoEntities.LayDSPhieuDatVatLieu_NCC();
                gridDSPhieuDat.DataSource = dsPhieuDat;
                gridDSPhieuDat.DataBind();

                foreach (GridViewRow gridRow in gridDSPhieuDat.Rows)
                {
                    Label lbTrangThai = (Label)gridRow.FindControl("lbTrangThai");
                    HyperLink link = (HyperLink)gridRow.FindControl("linkXuLy");
                    if (lbTrangThai.Text == "Đã xử lý")
                    { 
                        link.Visible = false;
                    }
                }
            }
        }

        protected void gridDSPhieuDat_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (!IsPostBack)
            {
                gridDSPhieuDat.DataSource = daoEntities.LayDSPhieuDatVatLieu_NCC();
                gridDSPhieuDat.PageIndex = e.NewPageIndex;
                gridDSPhieuDat.DataBind();
            }
        }
    }
}