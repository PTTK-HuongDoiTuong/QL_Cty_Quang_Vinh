using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using System.Data;

namespace PhanMemQLCTQuangVinh.Control
{
    public class XuLy_TiepNhanDonHang
    {
        public void LayDSKhachHang()
        {
            DAO_Entity dao = new DAO_Entity();
            dao.TaoDSKH();
        }
        public void TimtenKH(string ten)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.TimTheoTenKH(ten);
        }
        public void ThemKH(DTOKhachHang dtoKH)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemKhachHang(dtoKH);
        }
        public void LayttKH(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayTTKHTheoMa(ma);
        }
        public void themdh(DTODonDatHang dtodh)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemDonHang(dtodh);
        }
        public void themct(DTOChiTietDH dtoCTDH)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemChiTietDH(dtoCTDH);
        }
        public void themdatcoc(DTOThanhToan dtott)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemThanhToan(dtott);
        }
     
    }
}