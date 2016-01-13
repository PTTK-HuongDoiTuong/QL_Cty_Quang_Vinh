using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhieuGiao
    {
        public string MaPhieuGiao { get; set; }
        public string NgayGiao { get; set; }
        public string NguoiGiao { get; set; }

        public DTOPhieuGiao()
        { }

        public DTOPhieuGiao(DataRow dong)
        { 
            MaPhieuGiao = dong["MaPG"].ToString();
            NgayGiao = dong["NgayGiao"].ToString();
            NguoiGiao = dong["NguoiGiao"].ToString();
        }
    }
}