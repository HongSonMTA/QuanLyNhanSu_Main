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
    public partial class frmTGCTxCV : Form
    {
        ThoiGianCongTacEntity obj = new ThoiGianCongTacEntity();
        ThoiGianCongTacBUS bus = new ThoiGianCongTacBUS();
        ChucVuEntity obj1 = new ChucVuEntity();
        ChucVuBUS bus1 = new ChucVuBUS();
        private int fluu = 0;
        private int fluu1 = 0;
        public frmTGCTxCV()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnHuy.Enabled = e;
            btnLuu.Enabled = e;
            btnThem1.Enabled = !e;
            btnSua1.Enabled = !e;
            btnXoa1.Enabled = !e;
            btnLuu1.Enabled = e;
            btnHuy1.Enabled = e;
            txtMaNV.Enabled = e;
            txtMaCV.Enabled = e;
            //txtNgayNhanChuc.Enabled = e;
            txtMaChucVu.Enabled = e;
            txtTenChucVu.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtMaCV.Text = "";
            //txtNgayNhanChuc.Text = "";
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        private void HienThi()
        {
            dgvTGCT.DataSource = bus.GetData();
            dgvChucVu.DataSource = bus1.GetData();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void frmTGCTxCV_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvTGCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["clmMaNV"].Value);
            txtMaCV.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["clmMaCV"].Value);
            //txtNgayNhanChuc.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["Ngày Nhận Chức"].Value);
        }

        private void dgvTGCT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTGCT.Rows[e.RowIndex].Cells["clmSTT"].Value = e.RowIndex + 1;
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["clmMaCV1"].Value);
            txtTenChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["clmTenCV"].Value);
        }

        private void dgvChucVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChucVu.Rows[e.RowIndex].Cells["clmSTT1"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            fluu1 = 0;
            DisEnl(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            fluu = 1;
            DisEnl(true);
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            fluu1 = 1;
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.DeleteData(txtMaNV.Text);
                    MessageBox.Show("Xóa Thành Công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch
                {

                }
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus1.DeleteData(txtMaChucVu.Text);
                    MessageBox.Show("Xóa Thành Công!");
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
            obj.MaNV = txtMaNV.Text;
            obj.MaCV = txtMaCV.Text;
            obj.NgayNhanChuc = dtpNgayNhanChuc.Value;

            if (fluu == 0)
            {
                bus.InserData(obj);
                MessageBox.Show("Thêm Mới Thành Công!");
                HienThi();
                clearData();
                DisEnl(false);


            }
            else
            {
                bus.UpdateData(obj);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);


            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            obj1.MaChucVu = txtMaChucVu.Text;
            obj1.TenChucVu = txtTenChucVu.Text;
            if (fluu1 == 0)
            {
                bus1.InsertData(obj1);
                MessageBox.Show("Thêm Mới Thành Công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                bus1.UpdateData(obj1);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy thao tác đang làm không?", "Xác Nhận Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
            {
                return;
            }
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy thao tác đang làm không?", "Xác Nhận Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                HienThi();
            }
        }
    }
}
