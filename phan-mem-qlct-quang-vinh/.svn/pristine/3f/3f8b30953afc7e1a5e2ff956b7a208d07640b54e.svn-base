using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTONhacungcap
    {
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string Sdt { get; set; }
        public string Diachi { get; set; }

        public DTONhacungcap()
        { }

        public DTONhacungcap(DataRow dongDL)
        {
            MaNCC = (int)dongDL["MaNCC"];
            TenNCC = dongDL["TenNCC"].ToString();
            Sdt = dongDL["Sdt"].ToString();
            Diachi = dongDL["Diachi"].ToString();
        }
    }

}