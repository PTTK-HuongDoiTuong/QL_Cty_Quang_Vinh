using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOChiTietPhieuGiao
    {
        public DTOPhieuGiao dtoPhieuGiao { get; set; }
        public DTOVatLieu dtoVatLieu { get; set; }
        public int SoluongGiao { get; set; }
        public DTOChiTietPhieuGiao()
        { }

        public DTOChiTietPhieuGiao(DataRow dong)
        {
            dtoPhieuGiao = new DTOPhieuGiao(dong);
            dtoVatLieu = new DTOVatLieu(dong);
            SoluongGiao = (int)dong["SoLuongGiao"];
        }
    }
}