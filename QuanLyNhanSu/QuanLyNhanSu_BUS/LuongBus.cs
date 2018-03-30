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
    public class LuongBus
    {
        LuongDAL luong_DAL = new LuongDAL();
        public DataTable GetData()
        {
            return luong_DAL.GetData();
        }
        public DataTable GetDataByID(string ID)
        {
            return luong_DAL.GetDataByID(ID);
        }
        public int InsertData(LuongEntity lg)
        {
            return luong_DAL.InsertData(lg);
        }
        public int UpdateData(LuongEntity lg)
        {
            return luong_DAL.UpdateData(lg);
        }
        public int DeleteData(String ID)
        {
            return luong_DAL.DeleteData(ID);
        }
    }
}
