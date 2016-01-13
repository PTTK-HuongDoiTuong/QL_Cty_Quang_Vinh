using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOChamCong
    {
        public string MaCC { get; set; }
        public int MaNV { get; set; }
        public int MaSP { get; set; }
        public int Soluong { get; set; }

        public DTOChamCong()
        {
        }

        public DTOChamCong(DataRow dongDL)
        {
            MaCC = dongDL["macc"].ToString();
            MaNV = (int)dongDL["manv"];
            MaSP = (int)dongDL["masp"];
            Soluong = (int)dongDL["soluong"];            
        }
    }
}