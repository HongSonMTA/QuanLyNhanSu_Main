namespace QuanLyNhanSu
{
    partial class frmTGCTxCV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTGCTxCV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbNgayNhanChuc = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.lbMaCV = new System.Windows.Forms.Label();
            this.dgvTGCT = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbMaChucVu = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.lbTenChucVu = new System.Windows.Forms.Label();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnLuu1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSTT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaCV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTGCT = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGCT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTGCT);
            this.groupBox1.Controls.Add(this.txtMaCV);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lbMaCV);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.lbNgayNhanChuc);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thời gian công tác";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTGCT);
            this.groupBox2.Location = new System.Drawing.Point(1, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thời gian công tác";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(22, 19);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(120, 19);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // lbNgayNhanChuc
            // 
            this.lbNgayNhanChuc.AutoSize = true;
            this.lbNgayNhanChuc.Location = new System.Drawing.Point(22, 59);
            this.lbNgayNhanChuc.Name = "lbNgayNhanChuc";
            this.lbNgayNhanChuc.Size = new System.Drawing.Size(89, 13);
            this.lbNgayNhanChuc.TabIndex = 0;
            this.lbNgayNhanChuc.Text = "Ngày Nhận Chức";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(309, 19);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(100, 20);
            this.txtMaCV.TabIndex = 1;
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Location = new System.Drawing.Point(237, 19);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(66, 13);
            this.lbMaCV.TabIndex = 0;
            this.lbMaCV.Text = "Mã Chức Vụ";
            // 
            // dgvTGCT
            // 
            this.dgvTGCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTGCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmMaNV,
            this.clmMaCV,
            this.clmNgayNhanChuc});
            this.dgvTGCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTGCT.Location = new System.Drawing.Point(3, 16);
            this.dgvTGCT.Name = "dgvTGCT";
            this.dgvTGCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTGCT.Size = new System.Drawing.Size(493, 207);
            this.dgvTGCT.TabIndex = 0;
            this.dgvTGCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTGCT_CellClick);
            this.dgvTGCT.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTGCT_RowPrePaint);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(252, 86);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 49);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(178, 86);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 49);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(105, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 49);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(25, 86);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(51, 49);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(323, 86);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(55, 49);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(428, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 79);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHuy1);
            this.groupBox3.Controls.Add(this.btnLuu1);
            this.groupBox3.Controls.Add(this.btnXoa1);
            this.groupBox3.Controls.Add(this.btnSua1);
            this.groupBox3.Controls.Add(this.btnThem1);
            this.groupBox3.Controls.Add(this.txtTenChucVu);
            this.groupBox3.Controls.Add(this.lbTenChucVu);
            this.groupBox3.Controls.Add(this.txtMaChucVu);
            this.groupBox3.Controls.Add(this.lbMaChucVu);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(506, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 401);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chức vụ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChucVu);
            this.groupBox4.Location = new System.Drawing.Point(0, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 226);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chức vụ";
            // 
            // lbMaChucVu
            // 
            this.lbMaChucVu.AutoSize = true;
            this.lbMaChucVu.Location = new System.Drawing.Point(25, 37);
            this.lbMaChucVu.Name = "lbMaChucVu";
            this.lbMaChucVu.Size = new System.Drawing.Size(66, 13);
            this.lbMaChucVu.TabIndex = 1;
            this.lbMaChucVu.Text = "Mã Chức Vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(97, 34);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(100, 20);
            this.txtMaChucVu.TabIndex = 2;
            // 
            // lbTenChucVu
            // 
            this.lbTenChucVu.AutoSize = true;
            this.lbTenChucVu.Location = new System.Drawing.Point(212, 37);
            this.lbTenChucVu.Name = "lbTenChucVu";
            this.lbTenChucVu.Size = new System.Drawing.Size(70, 13);
            this.lbTenChucVu.TabIndex = 1;
            this.lbTenChucVu.Text = "Tên Chức Vụ";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(283, 37);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(100, 20);
            this.txtTenChucVu.TabIndex = 2;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT1,
            this.clmMaCV1,
            this.clmTenCV});
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.Location = new System.Drawing.Point(3, 16);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(399, 207);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            this.dgvChucVu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvChucVu_RowPrePaint);
            // 
            // btnThem1
            // 
            this.btnThem1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem1.Image = ((System.Drawing.Image)(resources.GetObject("btnThem1.Image")));
            this.btnThem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem1.Location = new System.Drawing.Point(28, 109);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(51, 49);
            this.btnThem1.TabIndex = 17;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnLuu1
            // 
            this.btnLuu1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu1.Enabled = false;
            this.btnLuu1.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu1.Image")));
            this.btnLuu1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu1.Location = new System.Drawing.Point(246, 109);
            this.btnLuu1.Name = "btnLuu1";
            this.btnLuu1.Size = new System.Drawing.Size(51, 49);
            this.btnLuu1.TabIndex = 19;
            this.btnLuu1.Text = "Lưu";
            this.btnLuu1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu1.UseVisualStyleBackColor = true;
            this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa1.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa1.Image")));
            this.btnXoa1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa1.Location = new System.Drawing.Point(172, 109);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(54, 49);
            this.btnXoa1.TabIndex = 20;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua1.Image = ((System.Drawing.Image)(resources.GetObject("btnSua1.Image")));
            this.btnSua1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua1.Location = new System.Drawing.Point(97, 109);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(53, 49);
            this.btnSua1.TabIndex = 21;
            this.btnSua1.Text = "Sửa";
            this.btnSua1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua1.UseVisualStyleBackColor = true;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnHuy1
            // 
            this.btnHuy1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy1.Enabled = false;
            this.btnHuy1.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy1.Image")));
            this.btnHuy1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy1.Location = new System.Drawing.Point(319, 109);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(55, 49);
            this.btnHuy1.TabIndex = 24;
            this.btnHuy1.Text = "Hủy";
            this.btnHuy1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy1.UseVisualStyleBackColor = true;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuy1_Click);
            // 
            // clmSTT
            // 
            this.clmSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.Name = "clmSTT";
            // 
            // clmMaNV
            // 
            this.clmMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMaNV.DataPropertyName = "MaNV";
            this.clmMaNV.HeaderText = "Mã Nhân Viên";
            this.clmMaNV.Name = "clmMaNV";
            // 
            // clmMaCV
            // 
            this.clmMaCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMaCV.DataPropertyName = "MaCV";
            this.clmMaCV.HeaderText = "Mã Chức Vụ";
            this.clmMaCV.Name = "clmMaCV";
            // 
            // clmNgayNhanChuc
            // 
            this.clmNgayNhanChuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNgayNhanChuc.DataPropertyName = "NgayNhanChuc";
            this.clmNgayNhanChuc.HeaderText = "Ngày Nhận Chức";
            this.clmNgayNhanChuc.Name = "clmNgayNhanChuc";
            // 
            // clmSTT1
            // 
            this.clmSTT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSTT1.HeaderText = "STT";
            this.clmSTT1.Name = "clmSTT1";
            // 
            // clmMaCV1
            // 
            this.clmMaCV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMaCV1.DataPropertyName = "MaChucVu";
            this.clmMaCV1.HeaderText = "Mã Chức Vụ";
            this.clmMaCV1.Name = "clmMaCV1";
            // 
            // clmTenCV
            // 
            this.clmTenCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTenCV.DataPropertyName = "TenChucVu";
            this.clmTenCV.HeaderText = "Tên Chức Vụ";
            this.clmTenCV.Name = "clmTenCV";
            // 
            // dtpTGCT
            // 
            this.dtpTGCT.Location = new System.Drawing.Point(120, 51);
            this.dtpTGCT.Name = "dtpTGCT";
            this.dtpTGCT.Size = new System.Drawing.Size(200, 20);
            this.dtpTGCT.TabIndex = 2;
            // 
            // frmTGCTxCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 402);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTGCTxCV";
            this.Text = "frmTGCTxCV";
            this.Load += new System.EventHandler(this.frmTGCTxCV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGCT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbMaCV;
        private System.Windows.Forms.Label lbNgayNhanChuc;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.DataGridView dgvTGCT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label lbTenChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label lbMaChucVu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Button btnLuu1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnSua1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayNhanChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaCV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenCV;
        private System.Windows.Forms.DateTimePicker dtpTGCT;
    }
}