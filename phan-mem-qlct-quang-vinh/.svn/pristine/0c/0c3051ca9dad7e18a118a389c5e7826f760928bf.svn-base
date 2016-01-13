using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PhanMemQLCTQuangVinh;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOXuLySuCo
    {
        public DTOSanPham dtoSP { get; set; }
        public int SoLuong { get; set; }

        public DTOXuLySuCo()
        { }

        public DTOXuLySuCo(DataRow dongDL)
        {
            dtoSP = new DTOSanPham(dongDL);
            SoLuong = (int)dongDL["SoLuong"];
        }
    }
}