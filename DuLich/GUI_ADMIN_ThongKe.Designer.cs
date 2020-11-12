namespace DuLich
{
    partial class GUI_ADMIN_ThongKe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.ckbNgay = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongThu = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbTenTour = new System.Windows.Forms.ComboBox();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duLichDataSet = new DuLich.DuLichDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tourTableAdapter = new DuLich.DuLichDataSetTableAdapters.tourTableAdapter();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTreEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNguoiLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.ckbNgay);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTongThu);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.lbThongBao);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.cbTenTour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 344);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(894, 271);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ckbNgay
            // 
            this.ckbNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbNgay.AutoSize = true;
            this.ckbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNgay.Location = new System.Drawing.Point(681, 271);
            this.ckbNgay.Name = "ckbNgay";
            this.ckbNgay.Size = new System.Drawing.Size(181, 24);
            this.ckbNgay.TabIndex = 1;
            this.ckbNgay.Text = "Nhận Điều Kiện Này";
            this.ckbNgay.UseVisualStyleBackColor = true;
            this.ckbNgay.CheckedChanged += new System.EventHandler(this.ckbNgay_CheckedChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDenNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(800, 182);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(180, 26);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Đến Ngày";
            // 
            // lbTongThu
            // 
            this.lbTongThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThu.Location = new System.Drawing.Point(112, 219);
            this.lbTongThu.Name = "lbTongThu";
            this.lbTongThu.Size = new System.Drawing.Size(184, 20);
            this.lbTongThu.TabIndex = 58;
            this.lbTongThu.Text = "0";
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(240, 268);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(86, 31);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(104, 182);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(531, 24);
            this.lbThongBao.TabIndex = 56;
            this.lbThongBao.Text = "Tổng từ tất cả tour đã được book:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTuNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(800, 109);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(180, 26);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Từ Ngày";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(148, 268);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(86, 31);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbTenTour
            // 
            this.cbTenTour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTenTour.DataSource = this.tourBindingSource;
            this.cbTenTour.DisplayMember = "matour";
            this.cbTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenTour.FormattingEnabled = true;
            this.cbTenTour.Location = new System.Drawing.Point(196, 111);
            this.cbTenTour.Name = "cbTenTour";
            this.cbTenTour.Size = new System.Drawing.Size(180, 28);
            this.cbTenTour.TabIndex = 0;
            this.cbTenTour.ValueMember = "matour";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mã Tour";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 36);
            this.label6.TabIndex = 41;
            this.label6.Text = "Thống Kê Doanh Thu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThongKe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 397);
            this.panel2.TabIndex = 0;
            // 
            // tourTableAdapter
            // 
            this.tourTableAdapter.ClearBeforeFill = true;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Thành Tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 125;
            // 
            // giaTour
            // 
            this.giaTour.DataPropertyName = "giaTour";
            this.giaTour.HeaderText = "Giá Tour";
            this.giaTour.MinimumWidth = 6;
            this.giaTour.Name = "giaTour";
            this.giaTour.ReadOnly = true;
            this.giaTour.Width = 125;
            // 
            // soTreEm
            // 
            this.soTreEm.DataPropertyName = "soTreEm";
            this.soTreEm.HeaderText = "Số Trẻ Em";
            this.soTreEm.MinimumWidth = 6;
            this.soTreEm.Name = "soTreEm";
            this.soTreEm.ReadOnly = true;
            this.soTreEm.Width = 125;
            // 
            // soNguoiLon
            // 
            this.soNguoiLon.DataPropertyName = "soNguoiLon";
            this.soNguoiLon.HeaderText = "Số Người Lớn";
            this.soNguoiLon.MinimumWidth = 6;
            this.soNguoiLon.Name = "soNguoiLon";
            this.soNguoiLon.ReadOnly = true;
            this.soNguoiLon.Width = 125;
            // 
            // ngayDatTour
            // 
            this.ngayDatTour.DataPropertyName = "ngayDatTour";
            this.ngayDatTour.HeaderText = "Ngày Đặt Tour";
            this.ngayDatTour.MinimumWidth = 6;
            this.ngayDatTour.Name = "ngayDatTour";
            this.ngayDatTour.ReadOnly = true;
            this.ngayDatTour.Width = 125;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Tên Khách Hàng";
            this.tenKhachHang.MinimumWidth = 6;
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            this.tenKhachHang.Width = 125;
            // 
            // maKhachHang
            // 
            this.maKhachHang.DataPropertyName = "maKhachHang";
            this.maKhachHang.HeaderText = "Mã Khách Hàng";
            this.maKhachHang.MinimumWidth = 6;
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.ReadOnly = true;
            this.maKhachHang.Width = 125;
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "tenTour";
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.ReadOnly = true;
            this.tenTour.Width = 125;
            // 
            // maTour
            // 
            this.maTour.DataPropertyName = "maTour";
            this.maTour.HeaderText = "Mã Tour";
            this.maTour.MinimumWidth = 6;
            this.maTour.Name = "maTour";
            this.maTour.ReadOnly = true;
            this.maTour.Width = 125;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTour,
            this.maKhachHang,
            this.tenKhachHang,
            this.ngayDatTour,
            this.soNguoiLon,
            this.soTreEm,
            this.giaTour,
            this.tongTien});
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 0);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1126, 397);
            this.dgvThongKe.TabIndex = 0;
            // 
            // GUI_ADMIN_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1150, 800);
            this.Name = "GUI_ADMIN_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_ADMIN_ThongKe";
            this.Load += new System.EventHandler(this.GUI_ADMIN_ThongKe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbTenTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTongThu;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Button btnXuat;
        private DuLichDataSet duLichDataSet;
        private System.Windows.Forms.BindingSource tourBindingSource;
        private DuLichDataSetTableAdapters.tourTableAdapter tourTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbNgay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNguoiLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTreEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
    }
}