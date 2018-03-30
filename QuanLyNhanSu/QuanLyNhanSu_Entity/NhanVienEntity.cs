using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Entity
{
    public class NhanVienEntity
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string DanToc { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaTDHV { get; set; }
        public string MaPB { get; set; }
        public int BacLuong { get; set; }

        public NhanVienEntity()
        {
            MaNV = "";
            HoTen = "";
            DanToc = "";
            GioiTinh = true;
            SDT = "";
            QueQuan = "";
            NgaySinh = DateTime.Parse("1/1/1997");
            MaTDHV = "";
            MaPB = "";
            BacLuong = 0;

        }
        public NhanVienEntity(string _MaNV, string _HoTen, string _DanToc, bool _GioiTinh, string _SDT, string _QueQuan, DateTime _NgaySinh, string _MaTDHV, string _MaPB, int _BacLuong)
        {
            MaNV = _MaNV;
            HoTen = _HoTen;
            DanToc = _DanToc;
            GioiTinh = _GioiTinh;
            SDT = _SDT;
            QueQuan = _QueQuan;
            NgaySinh = _NgaySinh;
            MaTDHV = _MaTDHV;
            MaPB = _MaPB;
            BacLuong = _BacLuong;
        }

    }
}
