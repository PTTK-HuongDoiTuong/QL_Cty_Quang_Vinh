using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhieudatVLCC
    {
        public string MaPDVLCC { get; set; }
        public int MaNCC { get; set; }
        public DateTime Ngaylap { get; set; }
        public DateTime NgayGiao { get; set; }
        public decimal TongTien { get; set; }
        public decimal CongNhoNCC { get; set; }
        public string GhiChu { get; set; }

        public DTOPhieudatVLCC()
        { }

        public DTOPhieudatVLCC(DataRow dongDL)
        {
            MaPDVLCC = dongDL["MaPDVLCC"].ToString();
            MaNCC = (int)dongDL["MaNCC"];
            Ngaylap = (DateTime)dongDL["Ngaylap"];
            NgayGiao = (DateTime)dongDL["NgayGiao"];
            TongTien = (decimal)dongDL["TongTien"];
            CongNhoNCC = (decimal)dongDL["CongNoNCC"];
            GhiChu = dongDL["Ghichu"].ToString();
        }
    }
}