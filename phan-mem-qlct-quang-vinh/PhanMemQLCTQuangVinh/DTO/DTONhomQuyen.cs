using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTONhomQuyen
    {
        public int MaNQ { get; set; }
        public string NhomQ { get; set; }

        public DTONhomQuyen()
        { }

        public DTONhomQuyen(DataRow dongDL)
        {
            MaNQ = (int)dongDL["MaNhomQ"];
            NhomQ = dongDL["NhomQuyen"].ToString();
        }
    }
}