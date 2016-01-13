using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOChiTietPhieuDatNCC
    {
        public DTOPhieuDatVatLieuCC PhieuDat { get; set; }
        public DTOVatLieu dtoVatLieu { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }

        public DTOChiTietPhieuDatNCC()
        { }

        public DTOChiTietPhieuDatNCC(DataRow dong)
        {
            PhieuDat = new DTOPhieuDatVatLieuCC(dong);
            dtoVatLieu = new DTOVatLieu(dong);
            SoLuong = (int)dong["SoLuong"];
            ThanhTien = (decimal)dong["Thanhtien"];
        }
    }
}