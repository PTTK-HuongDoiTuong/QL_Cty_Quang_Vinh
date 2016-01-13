using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOLuong
    {
        public string MaLuong { get; set; }
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaCC { get; set; }
        public int ThanhTien { get; set; }
        public string Ghichu { get; set; }
        public DTOLuong dtoLuong { get; set; }


        public DTOLuong()
        {
        }

        public DTOLuong(DataRow dongDL)
        {
            MaLuong = dongDL["MaLuong"].ToString();
            MaNV = (int)dongDL["MaNV"];
            TenNV = dongDL["TenNV"].ToString();
            MaCC = dongDL["MaCC"].ToString();
            ThanhTien = (int)dongDL["ThanhTien"];
            Ghichu = dongDL["Ghichu"].ToString();
        }
    }
}