using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOLoaiSP
    {
        public int MaLSP { get; set; }
        public string TenLSP { get; set; }

        public DTOLoaiSP()
        { }

        public DTOLoaiSP(DataRow dongDL)
        {
            MaLSP = (int)dongDL["MaLoai"];
            TenLSP = dongDL["TenLoai"].ToString();
        }
    }
}