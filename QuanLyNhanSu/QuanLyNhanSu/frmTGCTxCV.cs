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
        private int fluu = 1;
        public frmTGCTxCV()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThemTime.Enabled = !e;
            btnSuaTime.Enabled = !e;
            btnXoaTime.Enabled = !e;
            btnHuyTime.Enabled = e;
            btnLuuTime.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNV.Enabled = e;
            txtMaCV.Enabled = e;
            txtMaChucVu.Enabled = e;
            txtTenChucVu.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            txtMaCV.Text = "";
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        private void HienThi()
        {
            dgvTGCT.DataSource = bus.GetData();
            dgvChucVu.DataSource = bus1.GetData();
        }    
        private void frmTGCTxCV_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }
        private void btnThemTime_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
        }

        private void btnSuaTime_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
        }

        private void btnXoaTime_Click(object sender, EventArgs e)
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

        private void btnLuuTime_Click(object sender, EventArgs e)
        {
            obj.MaNV = txtMaNV.Text;
            obj.MaCV = txtMaCV.Text;
            obj.NgayNhanChuc = dpNgayNhanChuc.Value;

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

        private void btnHuyTime_Click(object sender, EventArgs e)
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

        private void btnThoatTime_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();

            }
            else
            {
                HienThi();
            }
        }

        private void dgvTGCT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["MaNV"].Value);
            txtMaCV.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["MaCV"].Value);
            dpNgayNhanChuc.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["NgayNhanChuc"].Value);
        }

        private void dgvTGCT_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTGCT.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            clearData();
            DisEnl(true);
            txtMaChucVu.Text = bus1.TangMa();
            txtMaChucVu.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaChucVu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
            obj1.MaChucVu = txtMaChucVu.Text;
            obj1.TenChucVu = txtTenChucVu.Text;
            if (fluu == 0)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();

            }
            else
            {
                HienThi();
            }
        }
        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            if (fluu == 0)
            {               
                txtTenChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["TenCV"].Value);
            }
            else
            {
                txtMaChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["MaCV1"].Value);
                txtTenChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["TenCV"].Value);
            }
        }

        private void dgvChucVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChucVu.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }
        //Chức Vụ/////////

    }
}
