using QuanLyNhanSu_BUS;
using QuanLyNhanSu_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmNhanVien : Form
    {
        NhanVienEntity obj = new NhanVienEntity();
        NhanVienBUS Bus = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtBacLuong.Text = "";
            txtDanToc.Text = "";
            txtHoTen.Text = "";
            txtMaTDHV.Text = "";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
            cbMaPB.Text = "";
        }

        // xử lý cbMaPB


        private void HienThi()
        {
            dgvNhanVien.DataSource = Bus.GetData();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
            txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["HoTen"].Value);
            txtDanToc.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DanToc"].Value);
            txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
            txtQueQuan.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["QueQuan"].Value);
            dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
            txtMaTDHV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaTDHV"].Value);
            cbMaPB.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaPB"].Value);
            txtBacLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["BacLuong"].Value);
            radNam.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
            radNu.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // xử lý
            obj.MaNV = txtMaNV.Text;
            obj.HoTen = txtHoTen.Text;
            obj.MaPB = cbMaPB.Text;
            obj.QueQuan = txtQueQuan.Text;
            obj.DanToc = txtDanToc.Text;
            obj.MaTDHV = txtMaTDHV.Text;
            obj.SDT = txtSDT.Text;
            obj.NgaySinh = dtNgaySinh.Value;

            int _luong;
            int.TryParse(txtBacLuong.Text, out _luong);

            obj.BacLuong = _luong;

            bool gt = true;
            if (radNam.Checked)
            {
                gt = true;
            }
            else gt = false;

            obj.GioiTinh = gt;
            // Thêm
            Bus.InsertData(obj);
            MessageBox.Show("Thêm thành công!");
            HienThi();
            clearData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Xử lý
            obj.MaNV = txtMaNV.Text;
            obj.HoTen = txtHoTen.Text;
            obj.MaPB = cbMaPB.Text;
            obj.QueQuan = txtQueQuan.Text;
            obj.DanToc = txtDanToc.Text;
            obj.MaTDHV = txtMaTDHV.Text;
            obj.SDT = txtSDT.Text;
            obj.NgaySinh = dtNgaySinh.Value;

            int _luong;
            int.TryParse(txtBacLuong.Text, out _luong);

            obj.BacLuong = _luong;

            bool gt = true;
            if (radNam.Checked)
            {
                gt = true;
            }
            else gt = false;

            obj.GioiTinh = gt;

            // sửa
            Bus.UpdateData(obj);
            MessageBox.Show("Sửa Thành Công ! ");
            HienThi();
            clearData();
        }
    }
}
