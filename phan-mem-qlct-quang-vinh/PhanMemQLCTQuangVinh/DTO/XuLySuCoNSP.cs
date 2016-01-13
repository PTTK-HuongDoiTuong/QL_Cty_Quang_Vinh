using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class XuLySuCoNSP
    {
        public string MaNSP { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int Soluong { get; set; }

        public XuLySuCoNSP()
        { }

        public XuLySuCoNSP(DataRow dongDL)
        {
            MaNSP = dongDL["MaNSP"].ToString();
            MaSP = (int)dongDL["MaSP"];
            TenSP = dongDL["TenSP"].ToString();
            Soluong = (int)dongDL["Soluong"];
        }
    }
}