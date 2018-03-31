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
    public class ThoiGianCongTacBUS
    {
        ThoiGianCongTacDAL TGCTDAL = new ThoiGianCongTacDAL();
        public DataTable GetData()
        {
            return TGCTDAL.GetData();
        }

        public DataTable GetDataByID(string ID)
        {
            return TGCTDAL.GetDataByID(ID);
        }

        public int InserData(ThoiGianCongTacEntity TGCT)
        {
            return TGCTDAL.InsertData(TGCT);
        }
        public int UpdateData(ThoiGianCongTacEntity TGCT)
        {
            return TGCTDAL.UpdateData(TGCT);
        }
        public int DeleteData(string ID)
        {
            return TGCTDAL.DeleteData(ID);
        }
    }
}
