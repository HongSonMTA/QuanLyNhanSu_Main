using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Entity
{
    public class ThoiGianCongTacEntity
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public DateTime NgayNhanChuc { get; set; }

        public ThoiGianCongTacEntity()
        {
            MaNV = "";
            MaCV = "";
            NgayNhanChuc = DateTime.Parse("9/6/1997");
        }
        public ThoiGianCongTacEntity(string _MaNV,string _MaCV,DateTime _NgayNhanChuc)
        {
            MaNV = _MaNV;
            MaCV = _MaCV;
            NgayNhanChuc = _NgayNhanChuc;
        }
    }
}
