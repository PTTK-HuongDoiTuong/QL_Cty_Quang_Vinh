﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOThanhToan
    {
        public int MaThanhToan { get; set; }
        public string MaDH { get; set; }
        public int MaNV { get; set; }
       // public DateTime NgayDat { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int Sotien { get; set; }
        public DateTime HanTT { get; set; }
     //   public DTODonDatHang dtoDDH { get; set; }

        public DTOThanhToan()
        { }

        public DTOThanhToan(DataRow dongDL)
        {
            MaThanhToan = (int)dongDL["MaThanhToan"];
            MaDH = dongDL["MaDH"].ToString();
            MaNV = (int)dongDL["MaNV"];
          
            NgayThanhToan = (DateTime)dongDL["NgayThanhToan"];
            Sotien = (int)dongDL["Sotien"];
            HanTT = (DateTime)dongDL["HanTT"];
          //  dtoDDH = new DTODonDatHang(dongDL); 
        }
    }
}