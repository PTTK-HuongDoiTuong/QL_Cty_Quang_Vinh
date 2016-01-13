using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOSanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int soluongGiao { get; set; }
        public int soluong { get; set; }
        public int Gia { get; set; }
        public DTOLoaiSP dtoLoaiSP { get; set; }

        public DTOSanPham()
        { }

        public DTOSanPham(DataRow dongDL)
        {
            MaSP = (int)dongDL["MaSP"];
            TenSP = dongDL["TenSP"].ToString();
            Gia = (int)dongDL["Gia"];
            dtoLoaiSP = new DTOLoaiSP(dongDL);
           //LoaiSP = new DTOLoaiSP(dongDL);
            soluong = (int)dongDL["soluong"];
            //GiaSP = (int)dongDL["GiaSP"];
        }
    }
}