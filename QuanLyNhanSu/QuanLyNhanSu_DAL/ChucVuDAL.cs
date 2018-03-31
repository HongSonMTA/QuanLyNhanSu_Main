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
    public class ChucVuDAL
    {
        KetNoi conn = new KetNoi();

        public DataTable GetData()
        {
            return conn.GetData("SP_CHUCVUSELECTALL", null);
        }

        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para = { new SqlParameter("MaChucVu", ID) };
            return conn.GetData("SP_CHUCVUIDSELECT", para);
        }

        public int InsertData(ChucVuEntity ChucVu)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaChucVu",ChucVu.MaChucVu),
                new SqlParameter("TenChucVu",ChucVu.TenChucVu)
            };
            return conn.ExcuteSQL("SP_ThemCHUCVU", para);
        }

        public int UpdateData(ChucVuEntity ChucVu)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaChucVu",ChucVu.MaChucVu),
                new SqlParameter("TenChucVu",ChucVu.TenChucVu)
            };
            return conn.ExcuteSQL("SP_SuaCHUCVU", para);
        }

        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaChucVu",ID)
            };
            return conn.ExcuteSQL("SP_XoaCHUCVU", para);
        }
    }
}
