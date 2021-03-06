﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOCongNoVatLieu
    {
        public int MaCNVL { get; set; }
        public int MaPDVLCC { get; set; }
        public int MaNCC { get; set; }

        public int MaNV { get; set; }
        public DateTime NgayTraNo { get; set; }
        public int Sotien { get; set; }

        public DTOCongNoVatLieu()
        {}

        public DTOCongNoVatLieu(DataRow dongDL)
        {
            MaCNVL = (int)dongDL["MaCNVL"];
            MaPDVLCC = (int)dongDL["MaPDVLCC"];
            MaNCC = (int)dongDL["MaNCC"];
            MaNV = (int)dongDL["MaNV"];
            NgayTraNo = (DateTime)dongDL["NgayTraNo"];
            Sotien = (int)dongDL["Sotien"];
        }

    }


}