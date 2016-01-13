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
    public partial class TraHang : System.Web.UI.Page
    {

        DAO_Entity daoEntities = new DAO_Entity();
        List<DTOChiTietDH> dsThanhPhamTra;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsPostBack == false)
                {

                    if (Request.QueryString["MaDH"] != null)
                    {
                        string maDH = Request.QueryString["MaDH"].ToString();
                        DTODonDatHang dtoDH = daoEntities.LayDonHangTraHang(maDH);
                        lbMaDH.Text = dtoDH.MaDH.ToString();
                        lbMaKH.Text = dtoDH.MaKH.ToString();
                        lbTenKH.Text = dtoDH.TenKH.ToString();

                    
                        List<DTOChiTietDH> dsChiTietDonHang = daoEntities.LayDSChiTietDH(maDH);
                        gridChiTietDonHang.DataSource = dsChiTietDonHang;
                        gridChiTietDonHang.DataBind();

                        gridDSCanTra.DataSource = dsChiTietDonHang;
                        gridDSCanTra.DataBind();

                        int tongtien = 0;
                        foreach (DTOChiTietDH dtoCT in dsChiTietDonHang)
                        {
                            tongtien += dtoCT.ThanhTien;
                        }
                        lbTongTienDaDat.Text = tongtien.ToString();
                    }

                }


            }
            catch
            {
                Response.Write("<script>alert('Loi tai du lieu!')</script>");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QLBoPhan_ThanhPham/QuanLyQuanNo_BH/DanhSachCongNo_BH.aspx");
        }

        


        protected void gridDSCanTra_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "them")
            {
                GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                int rowindex = row.RowIndex;
                TextBox txtSoluong = (TextBox)row.FindControl("txtSoluong");
                Label lbTenTP = (Label)row.FindControl("lbTenSP");
                Label lbGia = (Label)row.FindControl("lbGia");

                int maThanhPham = int.Parse(e.CommandArgument.ToString());
                int soluong = 0;
                int.TryParse(txtSoluong.Text, out soluong);
                int gia = int.Parse(lbGia.Text);
                string tenTP = lbTenTP.Text;

                

                if (Session["dsThanhPhamTra"] == null)
                {
                    dsThanhPhamTra = new List<DTOChiTietDH>();
                    Session["dsThanhPhamTra"] = dsThanhPhamTra;
                }
                else
                {
                    dsThanhPhamTra = (List<DTOChiTietDH>)Session["dsThanhPhamTra"];
                }

                bool trangthai = false;
                foreach (DTOChiTietDH t in dsThanhPhamTra)
                {
                    if (t.dtoSP.MaSP == maThanhPham)
                    {
                        t.SoLuong += soluong;
                        trangthai = true;
                        break;
                    }
                }
                if (trangthai == false)
                {
                    DTOChiTietDH tp = new DTOChiTietDH();
                    DTOSanPham dtoSP = daoEntities.TimTheoMaSP(maThanhPham);
                    tp.dtoSP = dtoSP;
                    tp.SoLuong = soluong;
                    tp.ThanhTien = gia * soluong;
                    dsThanhPhamTra.Add(tp);
                }

                hienThanhPhamChon();
                TongTien();
            }
        }

        private void TongTien()
        {
            int tongtien = 0;
            dsThanhPhamTra = (List<DTOChiTietDH>)Session["dsThanhPhamTra"];
            foreach (DTOChiTietDH row in dsThanhPhamTra)
            {
                tongtien += row.ThanhTien;
            }
            lbTongTien.Text = tongtien.ToString();
        }

        public void hienThanhPhamChon()
        {

            if (Session["dsThanhPhamTra"] == null)
            {

                gridDSChon.Visible = false;
            }
            else
            {
                dsThanhPhamTra = (List<DTOChiTietDH>)Session["dsThanhPhamTra"];
                //lbDSChon.Visible = true;

                gridDSChon.DataSource = dsThanhPhamTra;
                gridDSChon.DataBind();
            }
        }

        protected void gridChiTietDonHang_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (Request.QueryString["MaDH"] != null)
            {
                string makh = Request.QueryString["MaKH"].ToString();
                List<DTOChiTietDH> dsdh = daoEntities.LayDSChiTietDH(makh);
                gridChiTietDonHang.PageIndex = e.NewPageIndex;
                gridChiTietDonHang.DataSource = dsdh;
                gridChiTietDonHang.DataBind();
            }
            
        }

        protected void gridDSChon_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (Session["dsThanhPhamTra"] != null)
            {
                if (e.CommandName == "xoa")
                {
                    dsThanhPhamTra = (List<DTOChiTietDH>)Session["dsThanhPhamTra"];
                    int maTP = int.Parse(e.CommandArgument.ToString());
                    foreach (DTOChiTietDH t in dsThanhPhamTra)
                    {
                        if (t.dtoSP.MaSP == maTP)
                        {
                            dsThanhPhamTra.Remove(t);
                            break;
                        }
                    }
                    hienThanhPhamChon();
                    TongTien();
                }
            }
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            if (Session["dsThanhPhamTra"] != null)
            {
                dsThanhPhamTra = (List<DTOChiTietDH>)Session["dsThanhPhamTra"];
                int dem = 0;
                string maDH = lbMaDH.Text;
                foreach (DTOChiTietDH dtoCTDH in dsThanhPhamTra)
                {
                    DTOXLSC_HDBH dtoct = new DTOXLSC_HDBH();
                    dtoct.MaDH = lbMaDH.Text;
                    dtoct.MaSP = dtoCTDH.dtoSP.MaSP;
                    dtoct.Soluong = dtoCTDH.SoLuong;
                    dtoct.ThanhTien = dtoCTDH.ThanhTien;
                    if (daoEntities.ThemXuLyTraHang(dtoct))
                    {
                        DTOChiTietDH dtoChiTietDHTra = new DTOChiTietDH();
                        DTOChiTietDH dtoChiTietDonHangDat = daoEntities.LayChiTietDonHangTheoMaDHMaSP(maDH, dtoCTDH.dtoSP.MaSP);
                        dtoChiTietDHTra.MaDH = lbMaDH.Text;
                        dtoChiTietDHTra.MaSP = dtoCTDH.dtoSP.MaSP;
                        dtoChiTietDHTra.SoLuong = dtoChiTietDonHangDat.SoLuong - dtoCTDH.SoLuong;
                        dtoChiTietDHTra.ThanhTien = dtoChiTietDonHangDat.ThanhTien - dtoCTDH.ThanhTien;

                        if (daoEntities.CapNhatChiTietDH(dtoChiTietDHTra))
                            dem++;
                    }
                }

                if(dem == dsThanhPhamTra.Count)
                {
                    DTODonDatHang dtoDonHang = daoEntities.LayDHTheoMa(maDH);
                    int tongTienTra = int.Parse(lbTongTien.Text),
                        tongTienDaDat = dtoDonHang.TongTien,
                        congnoCu = dtoDonHang.CongNoDH,
                        tongTienPhaiTra = 0, congnoConLai = 0;
                    tongTienPhaiTra = tongTienDaDat - tongTienTra;
                    congnoConLai = congnoCu - tongTienTra;
                    daoEntities.CapNhatDonHang(maDH, tongTienPhaiTra, congnoConLai);
                }

                Response.Redirect(Request.RawUrl);
            }
        }

    }
}