namespace DoAnCKWin
{
    partial class FrmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang));
            this.btnXem = new System.Windows.Forms.Button();
            this.dtgvThe = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSdtGiamGia = new System.Windows.Forms.TextBox();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíThànhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiTrảHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ppdHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.pDHoaDon = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThe)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXem.Location = new System.Drawing.Point(281, 119);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(65, 23);
            this.btnXem.TabIndex = 22;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // dtgvThe
            // 
            this.dtgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThe.Location = new System.Drawing.Point(12, 155);
            this.dtgvThe.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvThe.Name = "dtgvThe";
            this.dtgvThe.RowHeadersWidth = 62;
            this.dtgvThe.RowTemplate.Height = 28;
            this.dtgvThe.Size = new System.Drawing.Size(333, 228);
            this.dtgvThe.TabIndex = 27;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(138, 121);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(140, 20);
            this.txtSDT.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "SDT khách hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(563, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHoaDon.Location = new System.Drawing.Point(362, 24);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(173, 40);
            this.btnTaoHoaDon.TabIndex = 23;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn mới";
            this.btnTaoHoaDon.UseVisualStyleBackColor = false;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSdtGiamGia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnInHoaDon);
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(362, 411);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 51);
            this.panel3.TabIndex = 19;
            // 
            // txtSdtGiamGia
            // 
            this.txtSdtGiamGia.Location = new System.Drawing.Point(3, 8);
            this.txtSdtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtSdtGiamGia.Name = "txtSdtGiamGia";
            this.txtSdtGiamGia.ReadOnly = true;
            this.txtSdtGiamGia.Size = new System.Drawing.Size(85, 20);
            this.txtSdtGiamGia.TabIndex = 10;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiamGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiamGia.Location = new System.Drawing.Point(3, 29);
            this.btnGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(84, 23);
            this.btnGiamGia.TabIndex = 9;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = false;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInHoaDon.Location = new System.Drawing.Point(336, 6);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(80, 45);
            this.btnInHoaDon.TabIndex = 7;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(105, 14);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(144, 23);
            this.txtThanhTien.TabIndex = 6;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThanhToan.Location = new System.Drawing.Point(252, 6);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(80, 45);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSoluong);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cbHangHoa);
            this.panel2.Controls.Add(this.lbMaNV);
            this.panel2.Controls.Add(this.cbLoaiHang);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Location = new System.Drawing.Point(362, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 48);
            this.panel2.TabIndex = 18;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(304, 17);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(44, 23);
            this.txtSoluong.TabIndex = 3;
            this.txtSoluong.Text = "1";
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(201, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 45);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbHangHoa.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(3, 25);
            this.cbHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(171, 22);
            this.cbHangHoa.TabIndex = 1;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(367, 20);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(40, 13);
            this.lbMaNV.TabIndex = 8;
            this.lbMaNV.Text = "Mã NV";
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(3, 3);
            this.cbLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(171, 24);
            this.cbLoaiHang.TabIndex = 0;
            this.cbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHang_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(409, 19);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(32, 20);
            this.txtMaNV.TabIndex = 7;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewHoaDon);
            this.panel1.Location = new System.Drawing.Point(362, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 266);
            this.panel1.TabIndex = 17;
            // 
            // listViewHoaDon
            // 
            this.listViewHoaDon.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewHoaDon.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHoaDon.FullRowSelect = true;
            this.listViewHoaDon.GridLines = true;
            this.listViewHoaDon.HideSelection = false;
            this.listViewHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewHoaDon.LabelEdit = true;
            this.listViewHoaDon.Location = new System.Drawing.Point(7, 0);
            this.listViewHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.listViewHoaDon.Name = "listViewHoaDon";
            this.listViewHoaDon.Size = new System.Drawing.Size(467, 262);
            this.listViewHoaDon.TabIndex = 0;
            this.listViewHoaDon.UseCompatibleStateImageBehavior = false;
            this.listViewHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền";
            this.columnHeader7.Width = 188;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.đăngKíThànhViênToolStripMenuItem,
            this.đổiTrảHàngToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // đăngKíThànhViênToolStripMenuItem
            // 
            this.đăngKíThànhViênToolStripMenuItem.Name = "đăngKíThànhViênToolStripMenuItem";
            this.đăngKíThànhViênToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.đăngKíThànhViênToolStripMenuItem.Text = "Đăng kí thành viên";
            // 
            // đổiTrảHàngToolStripMenuItem
            // 
            this.đổiTrảHàngToolStripMenuItem.Name = "đổiTrảHàngToolStripMenuItem";
            this.đổiTrảHàngToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.đổiTrảHàngToolStripMenuItem.Text = "Đổi trả hàng";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật  khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnCKWin.Properties.Resources.gio_hang;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 84);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ppdHoaDon
            // 
            this.ppdHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHoaDon.Enabled = true;
            this.ppdHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHoaDon.Icon")));
            this.ppdHoaDon.Name = "ppdHoaDon";
            this.ppdHoaDon.Visible = false;

            // 
            // pDHoaDon
            // 
            this.pDHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDHoaDon_PrintPage_1);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 539);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtgvThe);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThe)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dtgvThe;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSdtGiamGia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíThànhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiTrảHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog ppdHoaDon;
        private System.Drawing.Printing.PrintDocument pDHoaDon;
    }
}