using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOPhieuNVL_SX
    {
        public string MaPNVLSX { get; set; }
        public DTOPhieuDatVatLieuCC dtoPhieuDat { get; set; }
        public string ngaylap { get; set; }
        public string NgayGiao { get; set; }
        public string NguoiGiao { get; set; }
        public int MaNV { get; set; }

        public DTOPhieuNVL_SX()
        {}

        public DTOPhieuNVL_SX(DataRow dongDL)
        {
            MaPNVLSX = dongDL["MaPNVLSX"].ToString();
            dtoPhieuDat = new DTOPhieuDatVatLieuCC(dongDL);
            ngaylap = dongDL["Ngaylap"].ToString();
            NgayGiao = dongDL["Ngaygiao"].ToString();
            NguoiGiao = dongDL["NguoiGiao"].ToString();
            MaNV = (int)dongDL["MaNV"];
        }
    }
}