using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTODSDonHang
    {
        public string MaDH { get; set; }
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public DTOKhachHang dtoKH { get; set; }
        public DateTime NgayTaoDH { get; set; }
        public DateTime NgayGH { get; set; }
        public int TongTien { get; set; }
        public int CongNoDH { get; set; }
        public string TrangThai { get; set; }
        public DateTime HanTT { get; set; }
        public DateTime NgayThanhToan { get; set; }
     //   public int Sotien { get; set; }
    //    public int TongTienPG { get; set; }

        public DTODSDonHang()
        { }

        public DTODSDonHang(DataRow dongDL)
        {
            MaDH = dongDL["MaDH"].ToString();
            MaKH = (int)dongDL["MaKH"];
            TenKH = dongDL["TenKH"].ToString();
            dtoKH = new DTOKhachHang(dongDL);
            NgayTaoDH = (DateTime)dongDL["NgayTaoDH"];
            NgayGH = (DateTime)dongDL["NgayGH"];
            TongTien = (int)dongDL["TongTien"];
            CongNoDH = (int)dongDL["CongNoDH"];
            TrangThai = dongDL["TrangThai"].ToString();
            HanTT = (DateTime)dongDL["HanTT"];
            NgayThanhToan = (DateTime)dongDL["NgayThanhToan"];
         //   Sotien = (int)dongDL["Sotien"];
         //   TongTienPG = (int)dongDL["TongTienPG"];
        }
    }
}