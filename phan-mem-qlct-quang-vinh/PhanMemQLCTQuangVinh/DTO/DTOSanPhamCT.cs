using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOSanPhamCT
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int Gia { get; set; }
        public DTOLoaiSP dtoLoaiSP { get; set; }

        public DTOSanPhamCT()
        { }

        public DTOSanPhamCT(DataRow dongDL)
        {
            MaSP = (int)dongDL["MaSP"];
            TenSP = dongDL["TenSP"].ToString();
            Gia = (int)dongDL["Gia"];
            dtoLoaiSP = new DTOLoaiSP(dongDL);
        }
    }
}