namespace HRMPayrollSystem.GUI
{
    partial class FrmHRMMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNhanSu;
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.TabPage tabTinhLuong;

        // Tab 1 Controls
        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtCCCD, txtLuongCoBan, txtHeSoLuong, txtTimKiemNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Button btnThemNV, btnSuaNV, btnXoaNV, btnLamMoiNV, btnTimKiemNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;

        // Tab 2 Controls
        private System.Windows.Forms.TextBox txtThangNamCC;
        private System.Windows.Forms.Button btnNapChamCong, btnLuuChamCong;
        private System.Windows.Forms.DataGridView dgvChamCong;

        // Tab 3 Controls
        private System.Windows.Forms.TextBox txtThangNamLuong;
        private System.Windows.Forms.Button btnXemBangLuong, btnChotLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNhanSu = new System.Windows.Forms.TabPage();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl5 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.lblThangCC = new System.Windows.Forms.Label();
            this.txtThangNamCC = new System.Windows.Forms.TextBox();
            this.btnNapChamCong = new System.Windows.Forms.Button();
            this.btnLuuChamCong = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.tabTinhLuong = new System.Windows.Forms.TabPage();
            this.lblThangLuong = new System.Windows.Forms.Label();
            this.txtThangNamLuong = new System.Windows.Forms.TextBox();
            this.btnChotLuong = new System.Windows.Forms.Button();
            this.btnXemBangLuong = new System.Windows.Forms.Button();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.tabNhanSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.tabTinhLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabNhanSu);
            this.tabMain.Controls.Add(this.tabChamCong);
            this.tabMain.Controls.Add(this.tabTinhLuong);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(910, 575);
            this.tabMain.TabIndex = 0;
            // 
            // tabNhanSu
            // 
            this.tabNhanSu.BackColor = System.Drawing.Color.White;
            this.tabNhanSu.Controls.Add(this.lbl1);
            this.tabNhanSu.Controls.Add(this.txtMaNV);
            this.tabNhanSu.Controls.Add(this.lbl2);
            this.tabNhanSu.Controls.Add(this.txtHoTen);
            this.tabNhanSu.Controls.Add(this.lbl3);
            this.tabNhanSu.Controls.Add(this.txtCCCD);
            this.tabNhanSu.Controls.Add(this.lbl4);
            this.tabNhanSu.Controls.Add(this.dtpNgaySinh);
            this.tabNhanSu.Controls.Add(this.lbl5);
            this.tabNhanSu.Controls.Add(this.cboPhongBan);
            this.tabNhanSu.Controls.Add(this.lbl6);
            this.tabNhanSu.Controls.Add(this.txtLuongCoBan);
            this.tabNhanSu.Controls.Add(this.lbl7);
            this.tabNhanSu.Controls.Add(this.txtHeSoLuong);
            this.tabNhanSu.Controls.Add(this.btnThemNV);
            this.tabNhanSu.Controls.Add(this.btnSuaNV);
            this.tabNhanSu.Controls.Add(this.btnXoaNV);
            this.tabNhanSu.Controls.Add(this.btnLamMoiNV);
            this.tabNhanSu.Controls.Add(this.txtTimKiemNV);
            this.tabNhanSu.Controls.Add(this.btnTimKiemNV);
            this.tabNhanSu.Controls.Add(this.dgvNhanVien);
            this.tabNhanSu.Location = new System.Drawing.Point(4, 32);
            this.tabNhanSu.Name = "tabNhanSu";
            this.tabNhanSu.Size = new System.Drawing.Size(902, 539);
            this.tabNhanSu.TabIndex = 0;
            this.tabNhanSu.Text = "1. Hồ sơ Nhân sự (3-Tier CRUD)";
            this.tabNhanSu.Click += new System.EventHandler(this.tabNhanSu_Click);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 23);
            this.lbl1.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(110, 17);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 30);
            this.txtMaNV.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(0, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 23);
            this.lbl2.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(310, 17);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 30);
            this.txtHoTen.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(0, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 23);
            this.lbl3.TabIndex = 4;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(620, 17);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 30);
            this.txtCCCD.TabIndex = 5;
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(0, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 23);
            this.lbl4.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(110, 57);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 30);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(0, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 23);
            this.lbl5.TabIndex = 8;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Location = new System.Drawing.Point(370, 57);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(220, 31);
            this.cboPhongBan.TabIndex = 9;
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(0, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(100, 23);
            this.lbl6.TabIndex = 10;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(110, 97);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(150, 30);
            this.txtLuongCoBan.TabIndex = 11;
            // 
            // lbl7
            // 
            this.lbl7.Location = new System.Drawing.Point(0, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(100, 23);
            this.lbl7.TabIndex = 12;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(370, 97);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(100, 30);
            this.txtHeSoLuong.TabIndex = 13;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(20, 140);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(100, 35);
            this.btnThemNV.TabIndex = 14;
            this.btnThemNV.Text = "Thêm NV";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(130, 140);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(140, 35);
            this.btnSuaNV.TabIndex = 15;
            this.btnSuaNV.Text = "Sửa / Chuyển PB";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(280, 140);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(100, 35);
            this.btnXoaNV.TabIndex = 16;
            this.btnXoaNV.Text = "Xóa NV";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.Location = new System.Drawing.Point(390, 140);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoiNV.TabIndex = 17;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(530, 145);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(200, 30);
            this.txtTimKiemNV.TabIndex = 18;
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Location = new System.Drawing.Point(740, 140);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(120, 35);
            this.btnTimKiemNV.TabIndex = 19;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.Click += new System.EventHandler(this.btnTimKiemNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeight = 29;
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 190);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(860, 330);
            this.dgvNhanVien.TabIndex = 20;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // tabChamCong
            // 
            this.tabChamCong.BackColor = System.Drawing.Color.White;
            this.tabChamCong.Controls.Add(this.lblThangCC);
            this.tabChamCong.Controls.Add(this.txtThangNamCC);
            this.tabChamCong.Controls.Add(this.btnNapChamCong);
            this.tabChamCong.Controls.Add(this.btnLuuChamCong);
            this.tabChamCong.Controls.Add(this.lblHuongDan);
            this.tabChamCong.Controls.Add(this.dgvChamCong);
            this.tabChamCong.Location = new System.Drawing.Point(4, 32);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Size = new System.Drawing.Size(192, 64);
            this.tabChamCong.TabIndex = 1;
            this.tabChamCong.Text = "2. Chấm công Ngắt kết nối (Disconnected Model)";
            // 
            // lblThangCC
            // 
            this.lblThangCC.Location = new System.Drawing.Point(0, 0);
            this.lblThangCC.Name = "lblThangCC";
            this.lblThangCC.Size = new System.Drawing.Size(100, 23);
            this.lblThangCC.TabIndex = 0;
            // 
            // txtThangNamCC
            // 
            this.txtThangNamCC.Location = new System.Drawing.Point(200, 22);
            this.txtThangNamCC.Name = "txtThangNamCC";
            this.txtThangNamCC.Size = new System.Drawing.Size(120, 30);
            this.txtThangNamCC.TabIndex = 1;
            // 
            // btnNapChamCong
            // 
            this.btnNapChamCong.Location = new System.Drawing.Point(340, 18);
            this.btnNapChamCong.Name = "btnNapChamCong";
            this.btnNapChamCong.Size = new System.Drawing.Size(230, 36);
            this.btnNapChamCong.TabIndex = 2;
            this.btnNapChamCong.Text = "1. Nạp Bảng Chấm Công (Fill)";
            this.btnNapChamCong.Click += new System.EventHandler(this.btnNapChamCong_Click);
            // 
            // btnLuuChamCong
            // 
            this.btnLuuChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLuuChamCong.ForeColor = System.Drawing.Color.White;
            this.btnLuuChamCong.Location = new System.Drawing.Point(590, 18);
            this.btnLuuChamCong.Name = "btnLuuChamCong";
            this.btnLuuChamCong.Size = new System.Drawing.Size(280, 36);
            this.btnLuuChamCong.TabIndex = 3;
            this.btnLuuChamCong.Text = "2. Lưu Chấm Công (adapter.Update)";
            this.btnLuuChamCong.UseVisualStyleBackColor = false;
            this.btnLuuChamCong.Click += new System.EventHandler(this.btnLuuChamCong_Click);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Location = new System.Drawing.Point(0, 0);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(100, 23);
            this.lblHuongDan.TabIndex = 4;
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeight = 29;
            this.dgvChamCong.Location = new System.Drawing.Point(20, 100);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.Size = new System.Drawing.Size(860, 420);
            this.dgvChamCong.TabIndex = 5;
            // 
            // tabTinhLuong
            // 
            this.tabTinhLuong.BackColor = System.Drawing.Color.White;
            this.tabTinhLuong.Controls.Add(this.lblThangLuong);
            this.tabTinhLuong.Controls.Add(this.txtThangNamLuong);
            this.tabTinhLuong.Controls.Add(this.btnChotLuong);
            this.tabTinhLuong.Controls.Add(this.btnXemBangLuong);
            this.tabTinhLuong.Controls.Add(this.dgvBangLuong);
            this.tabTinhLuong.Location = new System.Drawing.Point(4, 32);
            this.tabTinhLuong.Name = "tabTinhLuong";
            this.tabTinhLuong.Size = new System.Drawing.Size(192, 64);
            this.tabTinhLuong.TabIndex = 2;
            this.tabTinhLuong.Text = "3. Tính Lương & Chốt Lương (SqlTransaction)";
            // 
            // lblThangLuong
            // 
            this.lblThangLuong.Location = new System.Drawing.Point(0, 0);
            this.lblThangLuong.Name = "lblThangLuong";
            this.lblThangLuong.Size = new System.Drawing.Size(100, 23);
            this.lblThangLuong.TabIndex = 0;
            // 
            // txtThangNamLuong
            // 
            this.txtThangNamLuong.Location = new System.Drawing.Point(200, 22);
            this.txtThangNamLuong.Name = "txtThangNamLuong";
            this.txtThangNamLuong.Size = new System.Drawing.Size(120, 30);
            this.txtThangNamLuong.TabIndex = 1;
            // 
            // btnChotLuong
            // 
            this.btnChotLuong.BackColor = System.Drawing.Color.DarkGreen;
            this.btnChotLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChotLuong.ForeColor = System.Drawing.Color.White;
            this.btnChotLuong.Location = new System.Drawing.Point(340, 18);
            this.btnChotLuong.Name = "btnChotLuong";
            this.btnChotLuong.Size = new System.Drawing.Size(300, 38);
            this.btnChotLuong.TabIndex = 2;
            this.btnChotLuong.Text = "CHỐT LƯƠNG THÁNG (SqlTransaction)";
            this.btnChotLuong.UseVisualStyleBackColor = false;
            this.btnChotLuong.Click += new System.EventHandler(this.btnChotLuong_Click);
            // 
            // btnXemBangLuong
            // 
            this.btnXemBangLuong.Location = new System.Drawing.Point(660, 18);
            this.btnXemBangLuong.Name = "btnXemBangLuong";
            this.btnXemBangLuong.Size = new System.Drawing.Size(180, 38);
            this.btnXemBangLuong.TabIndex = 3;
            this.btnXemBangLuong.Text = "Xem Bảng Lương";
            this.btnXemBangLuong.Click += new System.EventHandler(this.btnXemBangLuong_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.ColumnHeadersHeight = 29;
            this.dgvBangLuong.Location = new System.Drawing.Point(20, 80);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.Size = new System.Drawing.Size(860, 440);
            this.dgvBangLuong.TabIndex = 4;
            // 
            // FrmHRMMain
            // 
            this.ClientSize = new System.Drawing.Size(910, 575);
            this.Controls.Add(this.tabMain);
            this.Name = "FrmHRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 6.2 - HỆ THỐNG QUẢN LÝ NHÂN SỰ & TÍNH LƯƠNG (Lê Đức Khánh - D19CNPM5)";
            this.Load += new System.EventHandler(this.FrmHRMMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabNhanSu.ResumeLayout(false);
            this.tabNhanSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabChamCong.ResumeLayout(false);
            this.tabChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.tabTinhLuong.ResumeLayout(false);
            this.tabTinhLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblThangCC;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblThangLuong;
    }
}
