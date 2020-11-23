namespace CSDLPT_QLSV
{
    partial class frmSinhVien
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnTren = new System.Windows.Forms.Panel();
            this.lbThoat = new System.Windows.Forms.Label();
            this.lbReload = new System.Windows.Forms.Label();
            this.lbPhucHoi = new System.Windows.Forms.Label();
            this.lbXoa = new System.Windows.Forms.Label();
            this.lbGhi = new System.Windows.Forms.Label();
            this.lbHieuChinh = new System.Windows.Forms.Label();
            this.lbThem = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbNoiSinh = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.pnDuoi = new System.Windows.Forms.Panel();
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.pnGiua = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.qLDSV_DSPM = new CSDLPT_QLSV.QLDSV_DSPM();
            this.qLDSVDSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new CSDLPT_QLSV.QLDSV_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new CSDLPT_QLSV.QLDSV_DSPMTableAdapters.TableAdapterManager();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.pnTren.SuspendLayout();
            this.pnDuoi.SuspendLayout();
            this.pnKhoa.SuspendLayout();
            this.pnGiua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(1540, 86);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 913);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1540, 36);
            // 
            // pnTren
            // 
            this.pnTren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTren.Controls.Add(this.lbThoat);
            this.pnTren.Controls.Add(this.lbReload);
            this.pnTren.Controls.Add(this.lbPhucHoi);
            this.pnTren.Controls.Add(this.lbXoa);
            this.pnTren.Controls.Add(this.lbGhi);
            this.pnTren.Controls.Add(this.lbHieuChinh);
            this.pnTren.Controls.Add(this.lbThem);
            this.pnTren.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pnTren.Location = new System.Drawing.Point(0, 79);
            this.pnTren.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnTren.Name = "pnTren";
            this.pnTren.Size = new System.Drawing.Size(1538, 121);
            this.pnTren.TabIndex = 2;
            // 
            // lbThoat
            // 
            this.lbThoat.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.Image = global::CSDLPT_QLSV.Properties.Resources.logout;
            this.lbThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbThoat.Location = new System.Drawing.Point(1364, 4);
            this.lbThoat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(174, 83);
            this.lbThoat.TabIndex = 9;
            this.lbThoat.Text = "THOÁT";
            this.lbThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbReload
            // 
            this.lbReload.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReload.Image = global::CSDLPT_QLSV.Properties.Resources.refresh;
            this.lbReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbReload.Location = new System.Drawing.Point(970, -3);
            this.lbReload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReload.Name = "lbReload";
            this.lbReload.Size = new System.Drawing.Size(210, 91);
            this.lbReload.TabIndex = 8;
            this.lbReload.Text = "RELOAD";
            this.lbReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPhucHoi
            // 
            this.lbPhucHoi.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbPhucHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhucHoi.Image = global::CSDLPT_QLSV.Properties.Resources.restore;
            this.lbPhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPhucHoi.Location = new System.Drawing.Point(750, -3);
            this.lbPhucHoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhucHoi.Name = "lbPhucHoi";
            this.lbPhucHoi.Size = new System.Drawing.Size(212, 99);
            this.lbPhucHoi.TabIndex = 7;
            this.lbPhucHoi.Text = "PHỤC HỒI";
            this.lbPhucHoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbXoa
            // 
            this.lbXoa.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXoa.Image = global::CSDLPT_QLSV.Properties.Resources.delete;
            this.lbXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbXoa.Location = new System.Drawing.Point(596, 0);
            this.lbXoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbXoa.Name = "lbXoa";
            this.lbXoa.Size = new System.Drawing.Size(146, 94);
            this.lbXoa.TabIndex = 6;
            this.lbXoa.Text = "XÓA";
            this.lbXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGhi
            // 
            this.lbGhi.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbGhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhi.Image = global::CSDLPT_QLSV.Properties.Resources.floppy_disk;
            this.lbGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGhi.Location = new System.Drawing.Point(416, 1);
            this.lbGhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGhi.Name = "lbGhi";
            this.lbGhi.Size = new System.Drawing.Size(150, 88);
            this.lbGhi.TabIndex = 5;
            this.lbGhi.Text = "GHI";
            this.lbGhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHieuChinh
            // 
            this.lbHieuChinh.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbHieuChinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHieuChinh.Image = global::CSDLPT_QLSV.Properties.Resources.fix;
            this.lbHieuChinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHieuChinh.Location = new System.Drawing.Point(171, 3);
            this.lbHieuChinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHieuChinh.Name = "lbHieuChinh";
            this.lbHieuChinh.Size = new System.Drawing.Size(236, 92);
            this.lbHieuChinh.TabIndex = 1;
            this.lbHieuChinh.Text = "HIỆU CHỈNH";
            this.lbHieuChinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbThem
            // 
            this.lbThem.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lbThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThem.Image = global::CSDLPT_QLSV.Properties.Resources.add_friend;
            this.lbThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbThem.Location = new System.Drawing.Point(4, 4);
            this.lbThem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThem.Name = "lbThem";
            this.lbThem.Size = new System.Drawing.Size(150, 88);
            this.lbThem.TabIndex = 0;
            this.lbThem.Text = "THÊM";
            this.lbThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMaSV
            // 
            this.tbMaSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSV.Location = new System.Drawing.Point(94, 51);
            this.tbMaSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(446, 32);
            this.tbMaSV.TabIndex = 6;
            // 
            // tbHo
            // 
            this.tbHo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHo.Location = new System.Drawing.Point(94, 254);
            this.tbHo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(298, 32);
            this.tbHo.TabIndex = 7;
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(404, 254);
            this.tbTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(170, 32);
            this.tbTen.TabIndex = 8;
            // 
            // tbMaLop
            // 
            this.tbMaLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLop.Location = new System.Drawing.Point(94, 153);
            this.tbMaLop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(446, 32);
            this.tbMaLop.TabIndex = 9;
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.Location = new System.Drawing.Point(238, 307);
            this.cbNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(93, 31);
            this.cbNam.TabIndex = 10;
            this.cbNam.Text = "NAM";
            this.cbNam.UseVisualStyleBackColor = true;
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNu.Location = new System.Drawing.Point(370, 307);
            this.cbNu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(74, 31);
            this.cbNu.TabIndex = 11;
            this.cbNu.Text = "NỮ";
            this.cbNu.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Location = new System.Drawing.Point(854, 47);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(452, 32);
            this.dtNgaySinh.TabIndex = 12;
            // 
            // tbNoiSinh
            // 
            this.tbNoiSinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiSinh.Location = new System.Drawing.Point(854, 153);
            this.tbNoiSinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNoiSinh.Name = "tbNoiSinh";
            this.tbNoiSinh.Size = new System.Drawing.Size(452, 32);
            this.tbNoiSinh.TabIndex = 13;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(854, 254);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(452, 32);
            this.tbDiaChi.TabIndex = 14;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSV.Location = new System.Drawing.Point(90, 9);
            this.lbMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(181, 26);
            this.lbMaSV.TabIndex = 15;
            this.lbMaSV.Text = "MÃ SINH VIÊN";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(90, 108);
            this.lbMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(108, 26);
            this.lbMaLop.TabIndex = 16;
            this.lbMaLop.Text = "MÃ LỚP";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHo.Location = new System.Drawing.Point(90, 224);
            this.lbHo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(50, 26);
            this.lbHo.TabIndex = 17;
            this.lbHo.Text = "HỌ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(399, 224);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(60, 26);
            this.lbTen.TabIndex = 18;
            this.lbTen.Text = "TÊN";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(849, 9);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(144, 26);
            this.lbNgaySinh.TabIndex = 19;
            this.lbNgaySinh.Text = "NGÀY SINH";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiSinh.Location = new System.Drawing.Point(849, 108);
            this.lbNoiSinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(121, 26);
            this.lbNoiSinh.TabIndex = 20;
            this.lbNoiSinh.Text = "NƠI SINH";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(849, 224);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(105, 26);
            this.lbDiaChi.TabIndex = 21;
            this.lbDiaChi.Text = "ĐỊA CHỈ";
            // 
            // pnDuoi
            // 
            this.pnDuoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDuoi.Controls.Add(this.lbMaSV);
            this.pnDuoi.Controls.Add(this.tbDiaChi);
            this.pnDuoi.Controls.Add(this.lbDiaChi);
            this.pnDuoi.Controls.Add(this.tbMaSV);
            this.pnDuoi.Controls.Add(this.lbNoiSinh);
            this.pnDuoi.Controls.Add(this.tbNoiSinh);
            this.pnDuoi.Controls.Add(this.lbMaLop);
            this.pnDuoi.Controls.Add(this.lbNgaySinh);
            this.pnDuoi.Controls.Add(this.tbMaLop);
            this.pnDuoi.Controls.Add(this.dtNgaySinh);
            this.pnDuoi.Controls.Add(this.lbTen);
            this.pnDuoi.Controls.Add(this.lbHo);
            this.pnDuoi.Controls.Add(this.tbHo);
            this.pnDuoi.Controls.Add(this.cbNu);
            this.pnDuoi.Controls.Add(this.tbTen);
            this.pnDuoi.Controls.Add(this.cbNam);
            this.pnDuoi.Location = new System.Drawing.Point(0, 554);
            this.pnDuoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnDuoi.Name = "pnDuoi";
            this.pnDuoi.Size = new System.Drawing.Size(1538, 352);
            this.pnDuoi.TabIndex = 22;
            // 
            // pnKhoa
            // 
            this.pnKhoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnKhoa.Controls.Add(this.cbKhoa);
            this.pnKhoa.Controls.Add(this.lbKhoa);
            this.pnKhoa.Location = new System.Drawing.Point(0, 196);
            this.pnKhoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnKhoa.Name = "pnKhoa";
            this.pnKhoa.Size = new System.Drawing.Size(1538, 75);
            this.pnKhoa.TabIndex = 23;
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.Location = new System.Drawing.Point(513, 13);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(82, 29);
            this.lbKhoa.TabIndex = 0;
            this.lbKhoa.Text = "KHOA";
            // 
            // pnGiua
            // 
            this.pnGiua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnGiua.Controls.Add(this.tableLayoutPanel1);
            this.pnGiua.Location = new System.Drawing.Point(0, 259);
            this.pnGiua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnGiua.Name = "pnGiua";
            this.pnGiua.Size = new System.Drawing.Size(1538, 299);
            this.pnGiua.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1533, 294);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // qLDSV_DSPM
            // 
            this.qLDSV_DSPM.DataSetName = "QLDSV_DSPM";
            this.qLDSV_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDSVDSPMBindingSource
            // 
            this.qLDSVDSPMBindingSource.DataSource = this.qLDSV_DSPM;
            this.qLDSVDSPMBindingSource.Position = 0;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.qLDSV_DSPM;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_QLSV.QLDSV_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPM, "TENKHOA", true));
            this.cbKhoa.DataSource = this.bdsPM;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(606, 12);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(439, 33);
            this.cbKhoa.TabIndex = 3;
            this.cbKhoa.ValueMember = "TENSERVER";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 949);
            this.Controls.Add(this.pnGiua);
            this.Controls.Add(this.pnKhoa);
            this.Controls.Add(this.pnDuoi);
            this.Controls.Add(this.pnTren);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSinhVien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.pnTren.ResumeLayout(false);
            this.pnDuoi.ResumeLayout(false);
            this.pnDuoi.PerformLayout();
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            this.pnGiua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel pnTren;
        private System.Windows.Forms.Label lbThem;
        private System.Windows.Forms.Label lbHieuChinh;
        private System.Windows.Forms.Label lbGhi;
        private System.Windows.Forms.Label lbXoa;
        private System.Windows.Forms.Label lbPhucHoi;
        private System.Windows.Forms.Label lbReload;
        private System.Windows.Forms.Label lbThoat;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox tbNoiSinh;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Panel pnDuoi;
        private System.Windows.Forms.Panel pnKhoa;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Panel pnGiua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource qLDSVDSPMBindingSource;
        private QLDSV_DSPM qLDSV_DSPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private QLDSV_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSV_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbKhoa;
    }
}