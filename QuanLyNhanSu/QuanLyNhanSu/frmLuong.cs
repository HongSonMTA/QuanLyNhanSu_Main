using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu_Entity;
using QuanLyNhanSu_BUS;

namespace QuanLyNhanSu
{
    public partial class frmLuong : Form
    {
        LuongEntity obj = new LuongEntity();
        LuongBus Bus = new LuongBus();
        private int fluu = 0;
        public frmLuong()
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
            txtBacLuong.Enabled = e;
            txtLuongCoBan.Enabled = e;
            txtHeSoPhuCap.Enabled = e;
            txtHeSoLuong.Enabled = e;         
            txtTimKiem.Enabled = e;
            cmbTimKiem.Enabled = e;
        }
        private void clearData()
        {
            txtBacLuong.Text = "";
            txtLuongCoBan.Text = "";
            txtHeSoLuong.Text = "";
            txtHeSoPhuCap.Text = "";          
        }
        private void HienThi()
        {
            dgvLuong.DataSource = Bus.GetData();
        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBacLuong.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["BacLuong"].Value);
            txtLuongCoBan.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["LuongCoBan"].Value);
            txtHeSoLuong.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["HeSoLuong"].Value);
            txtHeSoPhuCap.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["HeSoPhuCap"].Value);
        }

        private void dgvLuong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLuong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtBacLuong.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch
                {

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.BacLuong = txtBacLuong.Text;
            obj.LuongCoBan = txtLuongCoBan.Text;
            obj.HeSoLuong = txtHeSoLuong.Text;
            obj.HeSoPhuCap = txtHeSoPhuCap.Text;

            if (fluu == 0)
            {
                Bus.InsertData(obj);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                Bus.UpdateData(obj);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                HienThi();
        }
    }
}
