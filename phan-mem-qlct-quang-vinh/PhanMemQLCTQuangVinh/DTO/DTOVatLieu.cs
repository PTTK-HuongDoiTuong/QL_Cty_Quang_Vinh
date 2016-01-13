using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOVatLieu
    {
        public int MaVL { get; set; }
        public string TenVL { get; set; }
        public DTONhacungcap dtoNCC { get; set; }
        public string Donvi { get; set; }
        public decimal Gia { get; set; }
        public int Soluong { get; set; }

        public DTOVatLieu()
        { }

        public DTOVatLieu(DataRow dongDL)
        {
            MaVL = (int)dongDL["MaVL"];
            TenVL = dongDL["TenVL"].ToString();
            dtoNCC = new DTONhacungcap(dongDL);
            Donvi = dongDL["Donvi"].ToString();
            Gia = (decimal)dongDL["Gia"];
            Soluong = (int)dongDL["Soluong"];

        }


    }
}