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
        public static List<NhanVienEntity> TimKiem(int type, string TuKhoa)
        {
            string query = "";
            KetNoi conn = new KetNoi();
            switch (type)
            {
                case 0:
                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNV LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 1:

                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE HoTen LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 2:
                    query = string.Format(" SELECT * FROM dbo.NhanVien NV, dbo.PhongBan PB WHERE NV.MaPB=PB.MaPB AND PB.TenPB LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 3:
                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE QueQuan LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
            }
            return Helper.ToListof<NhanVienEntity>(conn.GetData(" SELECT NV.MaNV,NV.HoTen,NV.DanToc,NV.GioiTinh,NV.SDT,NV.QueQuan,NV.NgaySinh,NV.MaTDHV,PB.TenPB,NV.BacLuong FROM dbo.NhanVien NV, dbo.PhongBan PB "));
        }
        public DataTable GetListBoPhan()
        {
            return conn.GetData("PB_SelectAll ", null);
        }
        public DataTable GetListLuong()
        {
            return conn.GetData("SP_Luong_SelectAll ", null);
        }
    }
}
