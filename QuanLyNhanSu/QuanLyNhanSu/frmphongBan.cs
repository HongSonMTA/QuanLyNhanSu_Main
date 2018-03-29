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
    public partial class frmphongBan : Form
    {
        PhongBanEntity obj = new PhongBanEntity();
        PhongbanBus Bus = new PhongbanBus();
        private int fluu = 0;
        public frmphongBan()
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
            txtMaPB.Enabled = e;
            txtTenPB.Enabled = e;
            txtDiaChi.Enabled = e;
            cmbMaTP.Enabled = e;
            txtSdt.Enabled = e;
            txtTimKiem.Enabled = e;
            cmbTimKiem.Enabled = e;
        }
        private void clearData()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            cmbMaTP.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
        }
        private void HienThi()
        {
            dgvPhongBan.DataSource = Bus.GetData();
        }
        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["MaPb"].Value);
            txtTenPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["TenPB"].Value);
            txtDiaChi.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["DiaChi"].Value);
            txtSdt.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["SDT"].Value);
            cmbMaTP.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["MaTP"].Value);

        }
        private void frmphongBan_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            
        }
        private void dgvPhongBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhongBan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaPB.Text);
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.MaPB = txtMaPB.Text;
            obj.TenPB = txtTenPB.Text;
            obj.MaTP = cmbMaTP.Text;
            obj.DiaChi = txtDiaChi.Text;
            obj.Sdt = txtSdt.Text;
            if(fluu == 0)
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
