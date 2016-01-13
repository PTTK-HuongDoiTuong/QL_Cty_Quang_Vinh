using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace PhanMemQLCTQuangVinh.DTO
{
    public class DTOUser
    {
        public string ID { get; set; }
        public string MK { get; set; }
        public string HTuser { get; set; }
        //public string NhomQuyen { get; set; }
        public int MaNQ { get; set; }
        public DTONhomQuyen dtoNhomQ { get; set; }

        public DTOUser()
        { }

        public DTOUser(DataRow dongDL)
        {

            ID = dongDL["IDUser"].ToString();
            MK = dongDL["MatKhau"].ToString();
            HTuser = dongDL["HoTenuser"].ToString();
           // NhomQuyen = dongDL["NhomQuyen"].ToString();
            MaNQ = (int)dongDL["MaNhomQ"];
            dtoNhomQ = new DTONhomQuyen(dongDL);
        }
    }
}