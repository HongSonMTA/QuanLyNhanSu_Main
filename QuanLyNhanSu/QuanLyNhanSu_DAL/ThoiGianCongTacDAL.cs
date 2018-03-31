using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu_Entity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu_DAL
{
    public class ThoiGianCongTacDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_TGCTSELECTALL", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para = { new SqlParameter("MaNV", ID) };
            return conn.GetData("SP_TGCTIDSELECT", para);
        }

        public int InsertData(ThoiGianCongTacEntity TGCT)
        {
            SqlParameter[] para = {
                new SqlParameter("MaNV", TGCT.MaNV),
                new SqlParameter("MaCV", TGCT.MaCV),
                new SqlParameter("NgayNhanChuc", TGCT.NgayNhanChuc),
            };
            return conn.ExcuteSQL("SP_ThemTGCT", para);
        }

        public int UpdateData(ThoiGianCongTacEntity TGCT)
        {
            SqlParameter[] para = {
                new SqlParameter("MaNV", TGCT.MaNV),
                new SqlParameter("MaCV", TGCT.MaCV),
                new SqlParameter("NgayNhanChuc", TGCT.NgayNhanChuc),
            };
            return conn.ExcuteSQL("SP_SuaTGCT", para);
        }

        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",ID)
            };
            return conn.ExcuteSQL("SP_XoaTGCT", para);
        }
    }
}
