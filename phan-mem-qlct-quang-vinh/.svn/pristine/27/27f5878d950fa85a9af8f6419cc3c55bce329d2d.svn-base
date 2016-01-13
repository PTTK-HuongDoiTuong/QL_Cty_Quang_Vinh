using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace PhanMemQLCTQuangVinh.DAO
{
    //Entity
    public class KetNoiCSDL
    {
        public SqlConnection KetNoi { get; set; } //tao ket noi voi sql server
        public SqlCommand LenhKetNoi { get; set; } //thuc thi lenh
        public SqlDataAdapter TichHopCSDL { get; set; }

        private string ChuoiKetNoi = ConfigurationManager.ConnectionStrings["CSDLQuangVinh"].ConnectionString;

        public KetNoiCSDL()
        {
            KetNoi = new SqlConnection(ChuoiKetNoi);
        }

        public void TaoKetNoi()
        {
            KetNoi.Open();
        }

        public void DongKetNoi()
        {
            KetNoi.Close();
        }
    }
}