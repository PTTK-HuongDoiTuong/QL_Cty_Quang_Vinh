using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhieuDatVatLieuCC
    {
        public string MaPDVLCC { get; set; }
        public DTONhacungcap dtoNhaCungCap { get; set; }
        public string TenNCC { get; set; }
        public DTONhacungcap dtoncc { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayGiao { get; set; }
        public decimal TongTien { get; set; }
        public decimal CongNoNCC { get; set; }
        public string TrangThai { get; set; }


        public DTOPhieuDatVatLieuCC()
        { }

        public DTOPhieuDatVatLieuCC(DataRow dongDL)
        {
            MaPDVLCC = dongDL["MaPDVLCC"].ToString();
            dtoNhaCungCap = new DTONhacungcap(dongDL);
            TenNCC = dongDL["TenNCC"].ToString();
            dtoncc = new DTONhacungcap(dongDL);
            NgayLap = (DateTime)dongDL["NgayLap"];
            NgayGiao = (DateTime)dongDL["NgayGiao"];
            TongTien = (decimal)dongDL["TongTien"];
            CongNoNCC = (decimal)dongDL["CongNoNCC"];
            int tt = (int)dongDL["TrangThai"];
            TrangThai = tt == 1 ? "Chưa xử lý" : "Đã xử lý";
        }
    }
}