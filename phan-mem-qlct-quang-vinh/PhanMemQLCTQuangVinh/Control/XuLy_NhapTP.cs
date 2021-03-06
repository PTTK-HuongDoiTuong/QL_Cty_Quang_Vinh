﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using System.Data;

namespace PhanMemQLCTQuangVinh.Control
{
    public class XuLy_NhapTP
    {
        //DSDonHangDangXuLy
        public void LayDHdangXL()
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSDonHangDangXuLy();
        }
        //ThemNhapThanhPham
        public void layCT_DonHang(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSChiTietDH(ma);
        }
        public void LuuPhieuNhap(DTONhapTP dtoPNTP)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemPhieuNhap(dtoPNTP);
        }

        public void themxulysuco(string maSuCo, int maSP, int soLuong)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemXuLySuCoPN(maSuCo, maSP, soLuong);
        }
        //Xulysuco
         public void xulysuco(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayXuLySucoTheoMa(ma);
        }
         public void capnhattrangthaidonhang(string maDH, string trangThai)
         {
             DAO_Entity dao = new DAO_Entity();
             dao.capNhatTrangThai(maDH,trangThai);
             
         }


    }
}