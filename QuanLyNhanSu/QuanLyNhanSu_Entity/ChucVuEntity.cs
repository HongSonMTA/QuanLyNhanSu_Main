using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Entity
{
    public class ChucVuEntity
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }

        public ChucVuEntity()
        {
            MaChucVu = "";
            TenChucVu = "";

        }
        public ChucVuEntity(string _MaChucVu, string _TenChucVu)
        {
            MaChucVu = _MaChucVu;
            TenChucVu = _TenChucVu;

        }
    }
}
