using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOKhachHang
    {
        //private string maKH;
        //public string MaKH
        //{
        //    get { return maKH; }
        //    set { maKH = value; }
        //}

        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string SdtKH { get; set; }
        public DTOLoaiKH dtoLoaiKH { get; set; }

        public DTOKhachHang()
        { }

        public DTOKhachHang(DataRow dongDL)
        {
            MaKH = (int)dongDL["makh"]; 
            //int.Parse(dongDL["makh"].ToString());
            TenKH = dongDL["tenkh"].ToString();
            DiaChiKH = dongDL["diachi"].ToString();
            SdtKH = dongDL["sdt"].ToString();
            dtoLoaiKH = new DTOLoaiKH(dongDL);
        } 
    }
}