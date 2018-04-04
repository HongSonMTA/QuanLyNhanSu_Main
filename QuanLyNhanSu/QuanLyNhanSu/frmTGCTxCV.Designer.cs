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
            this.ThoiGianCongTac = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThoatTime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTGCT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbNgayNhanChuc = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.lbMaCV = new System.Windows.Forms.Label();
            this.btnHuyTime = new System.Windows.Forms.Button();
            this.btnLuuTime = new System.Windows.Forms.Button();
            this.btnXoaTime = new System.Windows.Forms.Button();
            this.btnThemTime = new System.Windows.Forms.Button();
            this.btnSuaTime = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.lbTenChucVu = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.lbMaChucVu = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianCongTac.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // ThoiGianCongTac
            // 
            this.ThoiGianCongTac.Controls.Add(this.tabPage1);
            this.ThoiGianCongTac.Controls.Add(this.tabPage2);
            this.ThoiGianCongTac.Location = new System.Drawing.Point(0, 4);
            this.ThoiGianCongTac.Margin = new System.Windows.Forms.Padding(4);
            this.ThoiGianCongTac.Name = "ThoiGianCongTac";
            this.ThoiGianCongTac.SelectedIndex = 0;
            this.ThoiGianCongTac.Size = new System.Drawing.Size(1056, 435);
            this.ThoiGianCongTac.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnThoatTime);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnHuyTime);
            this.tabPage1.Controls.Add(this.btnLuuTime);
            this.tabPage1.Controls.Add(this.btnXoaTime);
            this.tabPage1.Controls.Add(this.btnThemTime);
            this.tabPage1.Controls.Add(this.btnSuaTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1048, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Thời Gian Công Tác";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThoatTime
            // 
            this.btnThoatTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatTime.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatTime.Image")));
            this.btnThoatTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoatTime.Location = new System.Drawing.Point(673, 120);
            this.btnThoatTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatTime.Name = "btnThoatTime";
            this.btnThoatTime.Size = new System.Drawing.Size(75, 62);
            this.btnThoatTime.TabIndex = 11;
            this.btnThoatTime.Text = "Thoát";
            this.btnThoatTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoatTime.UseVisualStyleBackColor = true;
            this.btnThoatTime.Click += new System.EventHandler(this.btnThoatTime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvTGCT);
            this.groupBox2.Location = new System.Drawing.Point(0, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1040, 207);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thời gian công tác";
            // 
            // dgvTGCT
            // 
            this.dgvTGCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTGCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.MaCV,
            this.NgayNhanChuc});
            this.dgvTGCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTGCT.Location = new System.Drawing.Point(4, 22);
            this.dgvTGCT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTGCT.Name = "dgvTGCT";
            this.dgvTGCT.Size = new System.Drawing.Size(1032, 181);
            this.dgvTGCT.TabIndex = 0;
            this.dgvTGCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTGCT_CellClick_1);
            this.dgvTGCT.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTGCT_RowPrePaint_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dpNgayNhanChuc);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.lbNgayNhanChuc);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.txtMaCV);
            this.groupBox1.Controls.Add(this.lbMaCV);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1036, 107);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thời gian công tác";
            // 
            // dpNgayNhanChuc
            // 
            this.dpNgayNhanChuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNgayNhanChuc.Location = new System.Drawing.Point(139, 73);
            this.dpNgayNhanChuc.Margin = new System.Windows.Forms.Padding(4);
            this.dpNgayNhanChuc.Name = "dpNgayNhanChuc";
            this.dpNgayNhanChuc.Size = new System.Drawing.Size(227, 25);
            this.dpNgayNhanChuc.TabIndex = 20;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(139, 31);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(227, 25);
            this.txtMaNV.TabIndex = 19;
            // 
            // lbNgayNhanChuc
            // 
            this.lbNgayNhanChuc.AutoSize = true;
            this.lbNgayNhanChuc.Location = new System.Drawing.Point(12, 82);
            this.lbNgayNhanChuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayNhanChuc.Name = "lbNgayNhanChuc";
            this.lbNgayNhanChuc.Size = new System.Drawing.Size(112, 17);
            this.lbNgayNhanChuc.TabIndex = 18;
            this.lbNgayNhanChuc.Text = "Ngày Nhận Chức";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(12, 34);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(95, 17);
            this.lbMaNV.TabIndex = 18;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(504, 34);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(204, 25);
            this.txtMaCV.TabIndex = 19;
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Location = new System.Drawing.Point(388, 39);
            this.lbMaCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(86, 17);
            this.lbMaCV.TabIndex = 18;
            this.lbMaCV.Text = "Mã Chức Vụ";
            // 
            // btnHuyTime
            // 
            this.btnHuyTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyTime.Enabled = false;
            this.btnHuyTime.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyTime.Image")));
            this.btnHuyTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyTime.Location = new System.Drawing.Point(540, 119);
            this.btnHuyTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyTime.Name = "btnHuyTime";
            this.btnHuyTime.Size = new System.Drawing.Size(78, 63);
            this.btnHuyTime.TabIndex = 17;
            this.btnHuyTime.Text = "Hủy";
            this.btnHuyTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyTime.UseVisualStyleBackColor = true;
            this.btnHuyTime.Click += new System.EventHandler(this.btnHuyTime_Click);
            // 
            // btnLuuTime
            // 
            this.btnLuuTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuTime.Enabled = false;
            this.btnLuuTime.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTime.Image")));
            this.btnLuuTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuTime.Location = new System.Drawing.Point(411, 119);
            this.btnLuuTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuTime.Name = "btnLuuTime";
            this.btnLuuTime.Size = new System.Drawing.Size(76, 63);
            this.btnLuuTime.TabIndex = 16;
            this.btnLuuTime.Text = "Lưu";
            this.btnLuuTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuTime.UseVisualStyleBackColor = true;
            this.btnLuuTime.Click += new System.EventHandler(this.btnLuuTime_Click);
            // 
            // btnXoaTime
            // 
            this.btnXoaTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTime.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTime.Image")));
            this.btnXoaTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaTime.Location = new System.Drawing.Point(298, 119);
            this.btnXoaTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTime.Name = "btnXoaTime";
            this.btnXoaTime.Size = new System.Drawing.Size(78, 63);
            this.btnXoaTime.TabIndex = 15;
            this.btnXoaTime.Text = "Xóa";
            this.btnXoaTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaTime.UseVisualStyleBackColor = true;
            this.btnXoaTime.Click += new System.EventHandler(this.btnXoaTime_Click);
            // 
            // btnThemTime
            // 
            this.btnThemTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTime.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTime.Image")));
            this.btnThemTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemTime.Location = new System.Drawing.Point(78, 119);
            this.btnThemTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTime.Name = "btnThemTime";
            this.btnThemTime.Size = new System.Drawing.Size(78, 63);
            this.btnThemTime.TabIndex = 13;
            this.btnThemTime.Text = "Thêm";
            this.btnThemTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemTime.UseVisualStyleBackColor = true;
            this.btnThemTime.Click += new System.EventHandler(this.btnThemTime_Click);
            // 
            // btnSuaTime
            // 
            this.btnSuaTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaTime.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTime.Image")));
            this.btnSuaTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaTime.Location = new System.Drawing.Point(193, 119);
            this.btnSuaTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaTime.Name = "btnSuaTime";
            this.btnSuaTime.Size = new System.Drawing.Size(72, 63);
            this.btnSuaTime.TabIndex = 14;
            this.btnSuaTime.Text = "Sửa";
            this.btnSuaTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaTime.UseVisualStyleBackColor = true;
            this.btnSuaTime.Click += new System.EventHandler(this.btnSuaTime_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1048, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Chức Vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.txtTenChucVu);
            this.groupBox3.Controls.Add(this.lbTenChucVu);
            this.groupBox3.Controls.Add(this.txtMaChucVu);
            this.groupBox3.Controls.Add(this.lbMaChucVu);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1036, 404);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chức vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(702, 131);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 62);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(541, 41);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(199, 25);
            this.txtTenChucVu.TabIndex = 24;
            // 
            // lbTenChucVu
            // 
            this.lbTenChucVu.AutoSize = true;
            this.lbTenChucVu.Location = new System.Drawing.Point(412, 49);
            this.lbTenChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenChucVu.Name = "lbTenChucVu";
            this.lbTenChucVu.Size = new System.Drawing.Size(89, 17);
            this.lbTenChucVu.TabIndex = 23;
            this.lbTenChucVu.Text = "Tên Chức Vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(142, 41);
            this.txtMaChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(228, 25);
            this.txtMaChucVu.TabIndex = 24;
            // 
            // lbMaChucVu
            // 
            this.lbMaChucVu.AutoSize = true;
            this.lbMaChucVu.Location = new System.Drawing.Point(8, 49);
            this.lbMaChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaChucVu.Name = "lbMaChucVu";
            this.lbMaChucVu.Size = new System.Drawing.Size(86, 17);
            this.lbMaChucVu.TabIndex = 23;
            this.lbMaChucVu.Text = "Mã Chức Vụ";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(583, 131);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 63);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(457, 131);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 63);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(344, 131);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 63);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(234, 131);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 63);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(116, 131);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 63);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvChucVu);
            this.groupBox4.Location = new System.Drawing.Point(0, 202);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1028, 194);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chức vụ";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaCV1,
            this.TenCV});
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.Location = new System.Drawing.Point(4, 22);
            this.dgvChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.Size = new System.Drawing.Size(1020, 168);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvChucVu_RowPrePaint);
            this.dgvChucVu.Click += new System.EventHandler(this.dgvChucVu_Click);
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            // 
            // MaCV1
            // 
            this.MaCV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCV1.DataPropertyName = "MaChucVu";
            this.MaCV1.HeaderText = "Mã Chức Vụ";
            this.MaCV1.Name = "MaCV1";
            // 
            // TenCV
            // 
            this.TenCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCV.DataPropertyName = "TenChucVu";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.Name = "TenCV";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // MaCV
            // 
            this.MaCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            // 
            // NgayNhanChuc
            // 
            this.NgayNhanChuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhanChuc.DataPropertyName = "NgayNhanChuc";
            this.NgayNhanChuc.HeaderText = "Ngày Nhận Chức";
            this.NgayNhanChuc.Name = "NgayNhanChuc";
            // 
            // frmTGCTxCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 436);
            this.Controls.Add(this.ThoiGianCongTac);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTGCTxCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTGCTxCV";
            this.Load += new System.EventHandler(this.frmTGCTxCV_Load);
            this.ThoiGianCongTac.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ThoiGianCongTac;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnThoatTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTGCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpNgayNhanChuc;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbNgayNhanChuc;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label lbMaCV;
        private System.Windows.Forms.Button btnHuyTime;
        private System.Windows.Forms.Button btnLuuTime;
        private System.Windows.Forms.Button btnXoaTime;
        private System.Windows.Forms.Button btnThemTime;
        private System.Windows.Forms.Button btnSuaTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label lbTenChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label lbMaChucVu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
    }
}