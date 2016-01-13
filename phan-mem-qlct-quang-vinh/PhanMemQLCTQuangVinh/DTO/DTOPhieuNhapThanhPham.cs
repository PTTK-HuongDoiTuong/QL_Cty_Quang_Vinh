﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhieuNhapThanhPham
    {
        public string MaPNTP { get; set; }
        public string MaPhieuGiao { get; set; }

        public DateTime NgayGiao { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NguoiGiao { get; set; }
        public string NguoiNhan { get; set; }
        public string MaDH { get; set; }

        public DTOPhieuNhapThanhPham()
        { }

        public DTOPhieuNhapThanhPham(DataRow dongDL)
        {
            MaPNTP = dongDL["MaNSP"].ToString();
            MaPhieuGiao = dongDL["MaPhieuGiao"].ToString();
            NgayGiao = (DateTime)dongDL["NgayGiao"];
            NgayNhap = (DateTime)dongDL["NgayNhap"];
            NguoiGiao = dongDL["NguoiGiao"].ToString();
        }
    }
}