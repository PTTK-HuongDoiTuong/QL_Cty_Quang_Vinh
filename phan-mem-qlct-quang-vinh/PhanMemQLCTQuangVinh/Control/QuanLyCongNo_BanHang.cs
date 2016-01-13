using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using PhanMemQLCTQuangVinh.DAO;
using System.Data;
namespace PhanMemQLCTQuangVinh.Control
{
    public class QuanLyCongNo_BanHang
    {
        public void LayDSCN_BH()
        {
            //DanhsachCongNoBH
            DAO_Entity dao = new DAO_Entity();
            dao.LayDSCongNoBH();

        }

        //thanh toan
        public void LayDH_theoma(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDHTheoMa(ma);
        }

        public void Thanhtoan(DTOThanhToan dtott)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.ThemThanhToan(dtott);
        }

        public void Xulytrahang(string ma)
        {
            DAO_Entity dao = new DAO_Entity();
            dao.LayDonHangTraHang(ma);

        }
    }
}