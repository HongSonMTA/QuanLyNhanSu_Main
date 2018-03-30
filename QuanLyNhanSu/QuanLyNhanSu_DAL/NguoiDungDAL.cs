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
    public class NguoiDungDAL
    {
        KetNoi conn = new KetNoi();
        
        public DataTable GetUser(string TaiKhoan, string MatKhau)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", TaiKhoan),
                                    new SqlParameter("MatKhau", MatKhau)};
            return conn.GetData("DangNhap", para);
        }

        public DataTable GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
