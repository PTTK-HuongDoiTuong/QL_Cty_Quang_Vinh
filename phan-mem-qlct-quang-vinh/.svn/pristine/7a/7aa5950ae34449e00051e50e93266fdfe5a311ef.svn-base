using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using System.Data;
namespace PhanMemQLCTQuangVinh.Control
{
    public class XuLy_NhapVLNCC
    {
        //danhsachphieudatvl
        public void DSPhieuDat_NCC()
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSPhieuDatVatLieu_NCC();
        }

        //NhapVatLieu
        public void LatchitietPD(string maPhieuDat)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.layDSVatLieuDaDat( maPhieuDat);
        }

        public void ThemPhieuNhap(DTOPhieuNVL_SX dtoPhieuVL)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemPhieuNhap(dtoPhieuVL);
        }

        public void themxuconhapVL(string maPhieu, int MaVL, int SoLuongKhongDat)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemXuLySuCo(maPhieu, MaVL, SoLuongKhongDat);
        }
    }
}