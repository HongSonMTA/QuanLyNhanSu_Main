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
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and MaNV LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 1:

                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and  HoTen LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 2:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and DanToc LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 3:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and GioiTinh LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 4:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and SDT LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 5:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and QueQuan LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 6:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and NgaySinh LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 7:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong AND TenTrinhDo LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 8:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong AND PhongBan.TenPB LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 9:
                    query = string.Format("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong and TienLuong LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
            }
            return Helper.ToListof<NhanVienEntity>(conn.GetData("SELECT MaNV,HoTen,DanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong = (LuongCoBan+LuongCoBan*HeSoLuong+HeSoPhuCap*100000) FROM dbo.NhanVien INNER JOIN dbo.PhongBan ON PhongBan.MaPB = NhanVien.MaPB INNER JOIN dbo.TrinhDoHocVan ON TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV INNER JOIN dbo.Luong ON Luong.BacLuong = NhanVien.BacLuong"));
        }
        public DataTable GetListBoPhan()
        {
            return conn.GetData("PB_SelectAll ", null);
        }
        public DataTable GetListLuong()
        {
            return conn.GetData("SP_Luong_SelectAll ", null);
        }
        public DataTable GetListTDHV()
        {
            return conn.GetData("SP_TDHV_SelectAll", null);
        }
    }
}
