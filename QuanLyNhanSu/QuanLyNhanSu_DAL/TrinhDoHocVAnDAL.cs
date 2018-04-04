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
    public class TrinhDoHocVanDAL
    {
        KetNoi kn = new KetNoi();
        public DataTable GetData()
        {
            return kn.GetData("SP_TDHV_SelectAll", null);
        }
        public DataTable GetDataByID(string id)
        {
            return kn.GetData(id);
        }
        public int ThemTDHV(TrinhDoHocVan obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTDHV",obj.MaTDHV),
                new SqlParameter("TenTDHV",obj.TenTrinhDo),
                new SqlParameter("ChuyenNganh",obj.ChuyenNganh)
            };
            return kn.ExcuteSQL("SP_Them_TDHV", para);
        }
        public int SuaTDHV(TrinhDoHocVan obj)
        {
            SqlParameter[] para =
             {
                new SqlParameter("MaTDHV",obj.MaTDHV),
                new SqlParameter("TenTDHV",obj.TenTrinhDo),
                new SqlParameter("ChuyenNganh",obj.ChuyenNganh)
            };
            return kn.ExcuteSQL("SP_Sua_TDHV", para);
        }
        public int XoaTDHV(string id)
        {
            SqlParameter[] para =
             {
                new SqlParameter("MaTDHV",id)
            };
            return kn.ExcuteSQL("SP_Xoa_TDHV", para);
        }
        public string TangMa()
        {
            return kn.TangMa("SELECT * FROM dbo.TrinhDoHocVan","TD");
        }
    }
}
