using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOKhoSP
    {
        public int STT { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int Soluong { get; set; }
        public DTOSanPham dtosp { get; set; }

        //public string DiaChi { get; set; }

        public DTOKhoSP()
        { }

        public DTOKhoSP(DataRow dongDL)
        {
            STT = (int)dongDL["STT"];
            MaSP = (int)dongDL["MaSP"];
            TenSP = dongDL["TenSP"].ToString();
            Soluong = (int)dongDL["Soluong"];
            dtosp = new DTOSanPham(dongDL);
            //DiaChi = dongDL["DiaChi"].ToString();

        }
    }
}