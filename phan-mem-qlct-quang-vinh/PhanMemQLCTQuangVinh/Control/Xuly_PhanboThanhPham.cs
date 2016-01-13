using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using System.Data;

namespace PhanMemQLCTQuangVinh.Control
{
    public class Xuly_PhanboThanhPham
    {
        public void LayDSDHang_Dasanxuat()
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSDonHang();
            
        }
        public void Themgiaohang(DTOHoaDonBH dto)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemPhieuGiaoHang(dto);
        }
        public void LayDonHangTheoMa(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDHTheoMa(ma);
        }
        public void LayCTDH(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSChiTietDH(ma);
        }
        public void LayDSkhosp()
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSKhoSP();
        }
        public void xuatpgiao(DTOXuLyPhieuGiao dtoCtDH)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemPhieuGiaoHang(dtoCtDH);
        }
    }
}