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
    public class LuongDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_Luong_SelectAll", null);
        }
        public DataTable GetDataByID(String ID)
        {
            SqlParameter[] para = { new SqlParameter("BacLuong", ID) };
            return conn.GetData("SP_Luong_SelectByID", para);
        }
        public int InsertData(LuongEntity luong)
        {
            SqlParameter[] para =
            {
                new SqlParameter("LuongCoBan",luong.LuongCoBan),
                new SqlParameter("BacLuong",luong.BacLuong),
                new SqlParameter("HeSoLuong",luong.HeSoLuong),
                new SqlParameter("HeSoPhuCap",luong.HeSoPhuCap)
            };
            return conn.ExcuteSQL("SP_ThemLuong ", para);
        }
        public int UpdateData(LuongEntity luong)
        {
            SqlParameter[] para =
            {
                new SqlParameter("LuongCoBan",luong.LuongCoBan),
                new SqlParameter("BacLuong",luong.BacLuong),
                new SqlParameter("HeSoLuong",luong.HeSoLuong),
                new SqlParameter("HeSoPhuCap",luong.HeSoPhuCap)
        };
            return conn.ExcuteSQL("SP_SuaLuong ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("BacLuong",ID)
        };
            return conn.ExcuteSQL("SP_XoaLuong ", para);
        }

        public string TangMa()
        {
            return conn.TangMa("Select * From Luong", "L");
        }
    }
}

