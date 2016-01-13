using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhanQuyen
    {
        public string MaQ { get; set; }
        public string TenQ { get; set; }

        public DTOPhanQuyen()
        { }

        public DTOPhanQuyen(DataRow dongDL)
        {
            MaQ = dongDL["MaQuyen"].ToString();
            TenQ = dongDL["TenQ"].ToString();
        }
    }
}