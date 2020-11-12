namespace DuLich
{
    partial class GUI_ADMIN_Tour
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
            this.components = new System.ComponentModel.Container();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duLichDataSet = new DuLich.DuLichDataSet();
            this.tourTableAdapter = new DuLich.DuLichDataSetTableAdapters.tourTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.MaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDenCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rtextLichTrinh = new System.Windows.Forms.RichTextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnAnh = new System.Windows.Forms.Button();
            this.txtLinkAnh = new System.Windows.Forms.TextBox();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.khuvucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaTour = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThoiGianTour = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiemDenCuoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemXuatPhat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tourBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.duLichDataSet1 = new DuLich.DuLichDataSet();
            this.khuvucTableAdapter = new DuLich.DuLichDataSetTableAdapters.khuvucTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataMember = "tour";
            this.tourBindingSource.DataSource = this.duLichDataSet;
            // 
            // duLichDataSet
            // 
            this.duLichDataSet.DataSetName = "DuLichDataSet";
            this.duLichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourTableAdapter
            // 
            this.tourTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 247);
            this.panel1.TabIndex = 0;
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTour,
            this.KhuVuc,
            this.TenTour,
            this.DiemXuatPhat,
            this.DiemDenCuoi,
            this.DichVu,
            this.NgayKhoiHanh,
            this.ThoiGianTour,
            this.GiaTour,
            this.link,
            this.lichTrinh});
            this.dgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTour.Location = new System.Drawing.Point(0, 0);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.RowTemplate.Height = 24;
            this.dgvTour.Size = new System.Drawing.Size(1126, 247);
            this.dgvTour.TabIndex = 0;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // MaTour
            // 
            this.MaTour.DataPropertyName = "matour";
            this.MaTour.HeaderText = "Mã Tour";
            this.MaTour.MinimumWidth = 6;
            this.MaTour.Name = "MaTour";
            this.MaTour.ReadOnly = true;
            this.MaTour.Width = 125;
            // 
            // KhuVuc
            // 
            this.KhuVuc.DataPropertyName = "tenkhuvuc";
            this.KhuVuc.HeaderText = "Khu Vực";
            this.KhuVuc.MinimumWidth = 6;
            this.KhuVuc.Name = "KhuVuc";
            this.KhuVuc.ReadOnly = true;
            this.KhuVuc.Width = 125;
            // 
            // TenTour
            // 
            this.TenTour.DataPropertyName = "tentour";
            this.TenTour.HeaderText = "Tên Tour";
            this.TenTour.MinimumWidth = 6;
            this.TenTour.Name = "TenTour";
            this.TenTour.ReadOnly = true;
            this.TenTour.Width = 125;
            // 
            // DiemXuatPhat
            // 
            this.DiemXuatPhat.DataPropertyName = "diemxuatphat";
            this.DiemXuatPhat.HeaderText = "Điểm Xuất Phát";
            this.DiemXuatPhat.MinimumWidth = 6;
            this.DiemXuatPhat.Name = "DiemXuatPhat";
            this.DiemXuatPhat.ReadOnly = true;
            this.DiemXuatPhat.Width = 125;
            // 
            // DiemDenCuoi
            // 
            this.DiemDenCuoi.DataPropertyName = "diemdencuoi";
            this.DiemDenCuoi.HeaderText = "Điểm Đến Cuối";
            this.DiemDenCuoi.MinimumWidth = 6;
            this.DiemDenCuoi.Name = "DiemDenCuoi";
            this.DiemDenCuoi.ReadOnly = true;
            this.DiemDenCuoi.Width = 125;
            // 
            // DichVu
            // 
            this.DichVu.DataPropertyName = "dichvu";
            this.DichVu.HeaderText = "Dịch Vụ";
            this.DichVu.MinimumWidth = 6;
            this.DichVu.Name = "DichVu";
            this.DichVu.ReadOnly = true;
            this.DichVu.Width = 125;
            // 
            // NgayKhoiHanh
            // 
            this.NgayKhoiHanh.DataPropertyName = "ngaykhoihanh";
            this.NgayKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.NgayKhoiHanh.MinimumWidth = 6;
            this.NgayKhoiHanh.Name = "NgayKhoiHanh";
            this.NgayKhoiHanh.ReadOnly = true;
            this.NgayKhoiHanh.Width = 125;
            // 
            // ThoiGianTour
            // 
            this.ThoiGianTour.DataPropertyName = "thoigiantour";
            this.ThoiGianTour.HeaderText = "Thời Gian Tour";
            this.ThoiGianTour.MinimumWidth = 6;
            this.ThoiGianTour.Name = "ThoiGianTour";
            this.ThoiGianTour.ReadOnly = true;
            this.ThoiGianTour.Width = 125;
            // 
            // GiaTour
            // 
            this.GiaTour.DataPropertyName = "giatour";
            this.GiaTour.HeaderText = "Giá Tour";
            this.GiaTour.MinimumWidth = 6;
            this.GiaTour.Name = "GiaTour";
            this.GiaTour.ReadOnly = true;
            this.GiaTour.Width = 125;
            // 
            // link
            // 
            this.link.DataPropertyName = "linkAnh";
            this.link.HeaderText = "Ảnh";
            this.link.MinimumWidth = 6;
            this.link.Name = "link";
            this.link.ReadOnly = true;
            this.link.Width = 125;
            // 
            // lichTrinh
            // 
            this.lichTrinh.DataPropertyName = "lichTrinh";
            this.lichTrinh.HeaderText = "Lịch Trình";
            this.lichTrinh.MinimumWidth = 6;
            this.lichTrinh.Name = "lichTrinh";
            this.lichTrinh.ReadOnly = true;
            this.lichTrinh.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.rtextLichTrinh);
            this.panel2.Controls.Add(this.picAnh);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.txtTim);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.btnAnh);
            this.panel2.Controls.Add(this.txtLinkAnh);
            this.panel2.Controls.Add(this.dtpNgayKhoiHanh);
            this.panel2.Controls.Add(this.cbKhuVuc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtGiaTour);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtThoiGianTour);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDichVu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDiemDenCuoi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDiemXuatPhat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTenTour);
            this.panel2.Controls.Add(this.txtMaTour);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 494);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Lịch Trình Tour";
            // 
            // rtextLichTrinh
            // 
            this.rtextLichTrinh.Location = new System.Drawing.Point(411, 100);
            this.rtextLichTrinh.Name = "rtextLichTrinh";
            this.rtextLichTrinh.Size = new System.Drawing.Size(351, 314);
            this.rtextLichTrinh.TabIndex = 36;
            this.rtextLichTrinh.Text = "";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(818, 100);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(299, 314);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 35;
            this.picAnh.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1037, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 31);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(759, 462);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(180, 26);
            this.txtTim.TabIndex = 13;
            this.txtTim.Text = "Mã hoặc tên tour";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(411, 460);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 31);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(626, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 31);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(521, 460);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 31);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(945, 460);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(86, 31);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnAnh
            // 
            this.btnAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.Location = new System.Drawing.Point(831, 58);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(86, 31);
            this.btnAnh.TabIndex = 9;
            this.btnAnh.Text = "Pick Ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // txtLinkAnh
            // 
            this.txtLinkAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLinkAnh.Enabled = false;
            this.txtLinkAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkAnh.Location = new System.Drawing.Point(923, 63);
            this.txtLinkAnh.Name = "txtLinkAnh";
            this.txtLinkAnh.Size = new System.Drawing.Size(180, 26);
            this.txtLinkAnh.TabIndex = 25;
            // 
            // dtpNgayKhoiHanh
            // 
            this.dtpNgayKhoiHanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayKhoiHanh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(184, 360);
            this.dtpNgayKhoiHanh.Name = "dtpNgayKhoiHanh";
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(180, 26);
            this.dtpNgayKhoiHanh.TabIndex = 6;
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbKhuVuc.DataSource = this.khuvucBindingSource;
            this.cbKhuVuc.DisplayMember = "tenkhuvuc";
            this.cbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(184, 110);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(180, 28);
            this.cbKhuVuc.TabIndex = 1;
            this.cbKhuVuc.ValueMember = "makhuvuc";
            // 
            // khuvucBindingSource
            // 
            this.khuvucBindingSource.DataMember = "khuvuc";
            this.khuvucBindingSource.DataSource = this.duLichDataSet;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Giá Tour";
            // 
            // txtGiaTour
            // 
            this.txtGiaTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTour.Location = new System.Drawing.Point(184, 460);
            this.txtGiaTour.Name = "txtGiaTour";
            this.txtGiaTour.Size = new System.Drawing.Size(180, 26);
            this.txtGiaTour.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Thời Gian Tour";
            // 
            // txtThoiGianTour
            // 
            this.txtThoiGianTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThoiGianTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianTour.Location = new System.Drawing.Point(184, 410);
            this.txtThoiGianTour.Name = "txtThoiGianTour";
            this.txtThoiGianTour.Size = new System.Drawing.Size(180, 26);
            this.txtThoiGianTour.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ngày Khởi Hành";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dịch Vụ";
            // 
            // txtDichVu
            // 
            this.txtDichVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichVu.Location = new System.Drawing.Point(184, 310);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(180, 26);
            this.txtDichVu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điểm Đến Cuối";
            // 
            // txtDiemDenCuoi
            // 
            this.txtDiemDenCuoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiemDenCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDenCuoi.Location = new System.Drawing.Point(184, 260);
            this.txtDiemDenCuoi.Name = "txtDiemDenCuoi";
            this.txtDiemDenCuoi.Size = new System.Drawing.Size(180, 26);
            this.txtDiemDenCuoi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Điểm Xuất Phát";
            // 
            // txtDiemXuatPhat
            // 
            this.txtDiemXuatPhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiemXuatPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemXuatPhat.Location = new System.Drawing.Point(184, 210);
            this.txtDiemXuatPhat.Name = "txtDiemXuatPhat";
            this.txtDiemXuatPhat.Size = new System.Drawing.Size(180, 26);
            this.txtDiemXuatPhat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTour.Location = new System.Drawing.Point(184, 160);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(180, 26);
            this.txtTenTour.TabIndex = 2;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTour.Location = new System.Drawing.Point(184, 60);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(180, 26);
            this.txtMaTour.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khu Vực";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Tour";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quản Lý Thông Tin Tour";
            // 
            // tourBindingSource1
            // 
            this.tourBindingSource1.DataMember = "tour";
            this.tourBindingSource1.DataSource = this.duLichDataSet1;
            // 
            // duLichDataSet1
            // 
            this.duLichDataSet1.DataSetName = "DuLichDataSet";
            this.duLichDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khuvucTableAdapter
            // 
            this.khuvucTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_ADMIN_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GUI_ADMIN_Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ADMIN_Tour";
            this.Load += new System.EventHandler(this.GUI_ADMIN_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DuLichDataSet duLichDataSet;
        private System.Windows.Forms.BindingSource tourBindingSource;
        private DuLichDataSetTableAdapters.tourTableAdapter tourTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Panel panel2;
        private DuLichDataSet duLichDataSet1;
        private System.Windows.Forms.BindingSource tourBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaTour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThoiGianTour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemDenCuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemXuatPhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.TextBox txtLinkAnh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.BindingSource khuvucBindingSource;
        private DuLichDataSetTableAdapters.khuvucTableAdapter khuvucTableAdapter;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDenCuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn lichTrinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtextLichTrinh;
    }
}