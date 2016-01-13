﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanMemQLCTQuangVinh.DTO;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOChiTietDonHang
    {

        //public int MaDH { get; set; }
     //   public int MaSP { get; set; }
       // public string TenSP { get; set; }
   //     public int Gia { get; set; }
        public DTODonDatHang dtoDH { get; set; }
        public DTOSanPham dtoSP { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        

        public DTOChiTietDonHang()
        { }

        public DTOChiTietDonHang(DataRow dongDL)
        {
            //MaDH = (int)dongDL["MaDH"];
        //    MaSP = (int)dongDL["MaSP"];
                     
           // TenSP = dongDL["TenSP"].ToString();
       //     Gia = (int)dongDL["Gia"];
            dtoDH = new DTODonDatHang(dongDL);
            dtoSP = new DTOSanPham(dongDL);
            SoLuong = (int)dongDL["SoLuong"];
            ThanhTien = (int)dongDL["ThanhTien"];
            
        }
    }
}