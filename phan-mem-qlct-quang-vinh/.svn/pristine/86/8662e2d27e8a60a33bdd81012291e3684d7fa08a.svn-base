using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOChiTietPhieuNhapVL
    {
        public DTOPhieuNVL_SX dtoPhieuNhapVL { get; set; }
        public DTOVatLieu dtoVatLieu { get; set; }
        public int SoLuongThuc { get; set; }
        public int SoLuongGiao { get; set; }

        public DTOChiTietPhieuNhapVL()
        { }

        public DTOChiTietPhieuNhapVL(DataRow dong)
        {
            dtoPhieuNhapVL = new DTOPhieuNVL_SX(dong);
            dtoVatLieu = new DTOVatLieu(dong);
            SoLuongThuc = (int)dong["Soluongthuc"];
            SoLuongGiao = (int)dong["Soluonggiao"];
        }
    }
}