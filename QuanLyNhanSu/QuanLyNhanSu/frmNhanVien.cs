﻿using QuanLyNhanSu_BUS;
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
using System.Data.SqlClient;
using QuanLyNhanSu_DAL;

namespace QuanLyNhanSu
{
    public partial class frmNhanVien : Form
    {
        NhanVienEntity obj = new NhanVienEntity();
        NhanVienBUS Bus = new NhanVienBUS();
        private int fluu = 1;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgaySinh.Enabled = e;      
            cmbBacLuong.Enabled = e;
            txtDanToc.Enabled = e;
            txtHoTen.Enabled = e;
            cmbMaPB.Enabled = e;
            txtMaNV.Enabled = e;
            cmbMaTDHV.Enabled = e;
            txtQueQuan.Enabled = e;
            txtSDT.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            cmbBacLuong.Text = "";
            txtDanToc.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
            cmbMaPB.Text = "";
            cmbMaTDHV.Text = "";
        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = Bus.GetData();
        }
        // xử lý cbMaPB


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {               
                txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["HoTen"].Value);
                txtDanToc.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DanToc"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                txtQueQuan.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["QueQuan"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                cmbMaTDHV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaTDHV"].Value);
                cmbMaPB.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaPB"].Value);
                cmbBacLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["BacLuong"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["HoTen"].Value);
                txtDanToc.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DanToc"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                txtQueQuan.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["QueQuan"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                cmbMaTDHV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaTDHV"].Value);
                cmbMaPB.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaPB"].Value);
                cmbBacLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["BacLuong"].Value);
                cmbGioiTinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value);
            }
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
                    DisEnl(false);
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
            fluu = 0;
            txtMaNV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = false;
            cbTimKiem.Enabled = false;
            HienThi();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            cbTimKiem.Enabled = true;
            if (txtTimKiem.Text.Trim() == "" || txtTimKiem.Text.Trim().Length > 50)
            {
                MessageBox.Show("Lỗi Từ khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvNhanVien.Refresh();
            dgvNhanVien.DataSource = QuanLyNhanSu_DAL.NhanVienDAL.TimKiem(cbTimKiem.SelectedIndex, txtTimKiem.Text.Trim());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // xử lý
            obj.MaNV = txtMaNV.Text;
            obj.HoTen = txtHoTen.Text;
            obj.MaPB = cmbMaPB.Text;
            obj.QueQuan = txtQueQuan.Text;
            obj.DanToc = txtDanToc.Text;
            obj.MaTDHV = cmbMaTDHV.Text;
            obj.SDT = txtSDT.Text;
            obj.NgaySinh = dtNgaySinh.Value;
            obj.BacLuong = cmbBacLuong.Text;
            obj.GioiTinh = cmbGioiTinh.Text;
            if (fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch (Exception )
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;
                
            }
            else
                return;
        }
    }
}
