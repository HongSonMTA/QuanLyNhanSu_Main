using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhanSu_Entity;
using QuanLyNhanSu_DAL;

namespace QuanLyNhanSu_BUS
{
    public class PhongbanBus
    {
        PhongbanDAL da = new PhongbanDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable GetDataByID(string ID)
        {
            return da.GetDataByID(ID);
        }
        public int InsertData(PhongBanEntity Pb)
        {
            return da.InsertData(Pb);
        }
        public int UpdateData(PhongBanEntity Pb)
        {
            return da.UpdateData(Pb);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        } 
    }
}
