using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOLoaiKH
    {
        public int MaLKH { get; set; }
        public string TenLKH { get; set; }

        public DTOLoaiKH()
        { }

        public DTOLoaiKH(DataRow dongDL)
        {
            MaLKH = (int)dongDL["MaLKH"];
            TenLKH = dongDL["TenLKH"].ToString();
        }
    }
}