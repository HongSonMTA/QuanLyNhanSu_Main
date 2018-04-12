using QuanLyNhanSu_DAL;
using QuanLyNhanSu_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL da = new NhanVienDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable GetListBoPhan()
        {
            return da.GetListBoPhan();
        }
        public DataTable GetListLuong()
        {
            return da.GetListLuong();
        }
        public DataTable GetListTDHV()
        {
            return da.GetListTDHV();
        }
        public int InsertData(NhanVienEntity NV)
        {
            return da.InsertData(NV);
        }
        public int UpdateData(NhanVienEntity NV)
        {
            return da.UpdateData(NV);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemNV(string strTimKiem)
        {
            return da.TimKiemNV(strTimKiem);
        }
    }
}
