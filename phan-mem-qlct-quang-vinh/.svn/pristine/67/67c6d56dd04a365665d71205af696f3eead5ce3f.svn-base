using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOTrangThai
    {
        public int MaTT { get; set; }
        public string TenTT { get; set; }

        public DTOTrangThai()
        { }

        public DTOTrangThai(DataRow dongDL)
        {
            MaTT = (int)dongDL["MaTT"];
            TenTT = dongDL["TenTT"].ToString();
        }
    }
}