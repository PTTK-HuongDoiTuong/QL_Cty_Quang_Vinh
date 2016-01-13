using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTO_XLSC_PNVLSX
    {
        public string MaPNVLSC { get; set; }
        public int MaVL { get; set; }
        public string Ghichu { get; set; }

        public DTO_XLSC_PNVLSX()
        { }

        public DTO_XLSC_PNVLSX(DataRow dongDL)
        {
            MaPNVLSC = dongDL["MaPNVLSX"].ToString();
            MaVL = (int)dongDL["MaVL"];
            Ghichu = dongDL["Ghichu"].ToString();
        }
    }
}