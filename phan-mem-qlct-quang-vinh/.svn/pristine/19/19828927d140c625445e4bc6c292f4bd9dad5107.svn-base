using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhieuXSP
    {
        public string MaXSP { get; set; }
        public DateTime Ngaylap { get; set; }
        public int MaSP { get; set; }
        public int Soluong { get; set; }
        public string Ghichu { get; set; }

        public DTOPhieuXSP()
        { }

        public DTOPhieuXSP(DataRow dongDL)
        {
            MaXSP = dongDL["MaXSP"].ToString();
            Ngaylap = (DateTime)dongDL["Ngaylap"];
            MaSP = (int)dongDL["MaSP"];
            Soluong = (int)dongDL["Soluong"];
            Ghichu = dongDL["Ghichu"].ToString();

        }
    }
}