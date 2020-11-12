namespace DuLich
{
    partial class GUI_TrangChu
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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.khuvucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duLichDataSet = new DuLich.DuLichDataSet();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNgayKhoiHanh = new System.Windows.Forms.CheckBox();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKhoangGia = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuGia = new System.Windows.Forms.TextBox();
            this.txtDenGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDSTour = new System.Windows.Forms.Panel();
            this.khuvucTableAdapter = new DuLich.DuLichDataSetTableAdapters.khuvucTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDSTour, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 773);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.Location = new System.Drawing.Point(1108, 54);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(159, 37);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tra Cứu Thông Tin Du Lịch";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 667);
            this.panel3.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(41, 560);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 39);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Refresh";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbKhuVuc);
            this.groupBox3.Location = new System.Drawing.Point(9, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 63);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khu Vực";
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.DataSource = this.khuvucBindingSource;
            this.cbKhuVuc.DisplayMember = "tenkhuvuc";
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(10, 32);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(166, 24);
            this.cbKhuVuc.TabIndex = 0;
            this.cbKhuVuc.ValueMember = "makhuvuc";
            // 
            // khuvucBindingSource
            // 
            this.khuvucBindingSource.DataMember = "khuvuc";
            this.khuvucBindingSource.DataSource = this.duLichDataSet;
            // 
            // duLichDataSet
            // 
            this.duLichDataSet.DataSetName = "DuLichDataSet";
            this.duLichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(41, 515);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 39);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNgayKhoiHanh);
            this.groupBox2.Controls.Add(this.txtDenNgay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTuNgay);
            this.groupBox2.Location = new System.Drawing.Point(9, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày Khởi Hành";
            // 
            // cbNgayKhoiHanh
            // 
            this.cbNgayKhoiHanh.AutoSize = true;
            this.cbNgayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgayKhoiHanh.Location = new System.Drawing.Point(10, 109);
            this.cbNgayKhoiHanh.Name = "cbNgayKhoiHanh";
            this.cbNgayKhoiHanh.Size = new System.Drawing.Size(152, 21);
            this.cbNgayKhoiHanh.TabIndex = 1;
            this.cbNgayKhoiHanh.Text = "Nhận điều kiện này";
            this.cbNgayKhoiHanh.UseVisualStyleBackColor = true;
            this.cbNgayKhoiHanh.CheckedChanged += new System.EventHandler(this.cbNgayKhoiHanh_CheckedChanged);
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Enabled = false;
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(71, 67);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(105, 22);
            this.txtDenNgay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Từ";
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Enabled = false;
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(71, 25);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(105, 22);
            this.txtTuNgay.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKhoangGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTuGia);
            this.groupBox1.Controls.Add(this.txtDenGia);
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoảng Giá";
            // 
            // cbKhoangGia
            // 
            this.cbKhoangGia.AutoSize = true;
            this.cbKhoangGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoangGia.Location = new System.Drawing.Point(10, 121);
            this.cbKhoangGia.Name = "cbKhoangGia";
            this.cbKhoangGia.Size = new System.Drawing.Size(152, 21);
            this.cbKhoangGia.TabIndex = 2;
            this.cbKhoangGia.Text = "Nhận điều kiện này";
            this.cbKhoangGia.UseVisualStyleBackColor = true;
            this.cbKhoangGia.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ";
            // 
            // txtTuGia
            // 
            this.txtTuGia.Enabled = false;
            this.txtTuGia.Location = new System.Drawing.Point(76, 21);
            this.txtTuGia.Name = "txtTuGia";
            this.txtTuGia.Size = new System.Drawing.Size(100, 22);
            this.txtTuGia.TabIndex = 1;
            // 
            // txtDenGia
            // 
            this.txtDenGia.Enabled = false;
            this.txtDenGia.Location = new System.Drawing.Point(76, 72);
            this.txtDenGia.Name = "txtDenGia";
            this.txtDenGia.Size = new System.Drawing.Size(100, 22);
            this.txtDenGia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            // 
            // panelDSTour
            // 
            this.panelDSTour.AutoScroll = true;
            this.panelDSTour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDSTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDSTour.Location = new System.Drawing.Point(203, 103);
            this.panelDSTour.Name = "panelDSTour";
            this.panelDSTour.Size = new System.Drawing.Size(1276, 667);
            this.panelDSTour.TabIndex = 3;
            // 
            // khuvucTableAdapter
            // 
            this.khuvucTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 773);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1500, 820);
            this.Name = "GUI_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_TrangChu_FormClosed);
            this.Load += new System.EventHandler(this.GUI_TrangChu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khuvucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLichDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuGia;
        private System.Windows.Forms.TextBox txtDenGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDSTour;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private DuLichDataSet duLichDataSet;
        private System.Windows.Forms.BindingSource khuvucBindingSource;
        private DuLichDataSetTableAdapters.khuvucTableAdapter khuvucTableAdapter;
        private System.Windows.Forms.DateTimePicker txtDenNgay;
        private System.Windows.Forms.DateTimePicker txtTuNgay;
        private System.Windows.Forms.CheckBox cbNgayKhoiHanh;
        private System.Windows.Forms.CheckBox cbKhoangGia;
        private System.Windows.Forms.Button btnReset;
    }
}