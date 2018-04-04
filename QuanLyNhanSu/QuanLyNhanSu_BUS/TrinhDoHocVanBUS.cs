using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu_Entity;
using QuanLyNhanSu_DAL;
using System.Data;

namespace QuanLyNhanSu_BUS
{
    public class TrinhDoHocVanBUS
    {
        TrinhDoHocVanDAL tdhvdal = new TrinhDoHocVanDAL();
        public DataTable GetData()
        {
            return tdhvdal.GetData();
        }
        public int ThemTDHV(TrinhDoHocVan obj)
        {
            return tdhvdal.ThemTDHV(obj);
        }
        public int SuaTDHV(TrinhDoHocVan obj)
        {
            return tdhvdal.SuaTDHV(obj);
        }
        public int XoaTDHV(string id)
        {
            return tdhvdal.XoaTDHV(id);
        }
        public string TangMa()
        {
            return tdhvdal.TangMa();
        }
    }
}
