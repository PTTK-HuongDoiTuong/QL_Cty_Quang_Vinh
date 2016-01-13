using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOXLSC_HDBH
    {
        public int STT { get; set; }
        public string MaDH { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int Gia { get; set; }
        public DTOSanPham dtosp { get; set; }
        public DTODonDatHang dtoDH { get; set; }
        public int Soluong { get; set; }
        public int ThanhTien { get; set; }

        public DTOXLSC_HDBH()
        { }

        public DTOXLSC_HDBH(DataRow dongDL)
        {
            STT = (int)dongDL["STT"];
            MaDH = dongDL["MaDH"].ToString();
            MaSP = (int)dongDL["MaSP"];
            TenSP = dongDL["TenSP"].ToString();
            Gia = (int)dongDL["Gia"];
            dtosp = new DTOSanPham(dongDL);
            dtoDH = new DTODonDatHang(dongDL);
            Soluong = (int)dongDL["Soluong"];
            ThanhTien = (int)dongDL["ThanhTien"];

        }
    }
}