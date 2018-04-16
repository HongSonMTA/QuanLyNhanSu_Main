using QuanLyNhanSu_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_DAL
{
    public class NhanVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("NV_SelectAll", null);
        }
        public int InsertData(NhanVienEntity NV)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("MaNV",NV.MaNV),
                new SqlParameter("HoTen",NV.HoTen),
                new SqlParameter("DanToc",NV.DanToc),
                new SqlParameter("GioiTinh",NV.GioiTinh),
                new SqlParameter ("SDT",NV.SDT),
                new SqlParameter("QueQuan",NV.QueQuan),
                new SqlParameter("NgaySinh",NV.NgaySinh),
                new SqlParameter("MaTDHV",NV.MaTDHV),
                new SqlParameter("MaPB",NV.MaPB),
                new SqlParameter ("BacLuong",NV.BacLuong)
            };
            return conn.ExcuteSQL("ThemNV", para);
        }
        public int UpdateData(NhanVienEntity NV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",NV.MaNV),
                new SqlParameter("HoTen",NV.HoTen),
                new SqlParameter("DanToc",NV.DanToc),
                new SqlParameter("GioiTinh",NV.GioiTinh),
                new SqlParameter ("SDT",NV.SDT),
                new SqlParameter("QueQuan",NV.QueQuan),
                new SqlParameter("NgaySinh",NV.NgaySinh),
                new SqlParameter("MaTDHV",NV.MaTDHV),
                new SqlParameter("MaPB",NV.MaPB),
                new SqlParameter ("BacLuong",NV.BacLuong)
        };
            return conn.ExcuteSQL("SuaNV ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",ID)
        };
            return conn.ExcuteSQL("XoaNV", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NhanVien", "NV");
        }
        public DataTable TimKiemNV(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        
        public DataTable GetListBoPhan()
        {
            return conn.GetData("PB_Select ", null);
        }
        public DataTable GetListLuong()
        {
            return conn.GetData("SP_Luong_SelectAll ", null);
        }
        public DataTable GetListTDHV()
        {
            return conn.GetData("SP_TDHV_SelectAll", null);
        }
        public DataTable GetListChucVu()
        {
            return conn.GetData("SPCVSELECTAll ", null);
        }
    }
}
