namespace CSDLPT_QLSV
{
    partial class frmDongHocPhi
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
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDongHocPhi));
            this.pnTren = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.pnKhoa = new System.Windows.Forms.Panel();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.cT_DONGHOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_SERVER3 = new CSDLPT_QLSV.QLDSV_SERVER3();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_DONGHOCPHITableAdapter = new CSDLPT_QLSV.QLDSV_SERVER3TableAdapters.CT_DONGHOCPHITableAdapter();
            this.tableAdapterManager = new CSDLPT_QLSV.QLDSV_SERVER3TableAdapters.TableAdapterManager();
            this.bdsDongHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DONGHOCPHITableAdapter = new CSDLPT_QLSV.QLDSV_SERVER3TableAdapters.SP_DONGHOCPHITableAdapter();
            this.sINHVIENTableAdapter = new CSDLPT_QLSV.QLDSV_SERVER3TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager1 = new CSDLPT_QLSV.QLDSV_DSPMTableAdapters.TableAdapterManager();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIÊNKHÓA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHỌCKỲ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHỌCPHÍ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIỀNĐÃĐÓNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSỐTIỀNĐÓNG = new DevExpress.XtraGrid.Columns.GridColumn();
            mASVLabel = new System.Windows.Forms.Label();
            this.pnTren.SuspendLayout();
            this.pnKhoa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_DONGHOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_SERVER3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDongHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Trajan Pro 3", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(467, 32);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(91, 31);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MÃ SV:";
            // 
            // pnTren
            // 
            this.pnTren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTren.Controls.Add(this.btnThoat);
            this.pnTren.Controls.Add(this.btnUndo);
            this.pnTren.Controls.Add(this.btnLuu);
            this.pnTren.Controls.Add(this.btnThem);
            this.pnTren.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pnTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTren.Location = new System.Drawing.Point(0, 0);
            this.pnTren.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnTren.Name = "pnTren";
            this.pnTren.Size = new System.Drawing.Size(1582, 53);
            this.pnTren.TabIndex = 30;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThoat.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThoat.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseBorderColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.AppearanceDisabled.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Location = new System.Drawing.Point(1073, 5);
            this.btnThoat.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnThoat.Margin = new System.Windows.Forms.Padding(28, 26, 28, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 40);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "THOÁT";
            // 
            // btnUndo
            // 
            this.btnUndo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUndo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUndo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUndo.Appearance.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Appearance.Options.UseBackColor = true;
            this.btnUndo.Appearance.Options.UseBorderColor = true;
            this.btnUndo.Appearance.Options.UseFont = true;
            this.btnUndo.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUndo.AppearanceDisabled.Options.UseFont = true;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Location = new System.Drawing.Point(748, 5);
            this.btnUndo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnUndo.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(187, 40);
            this.btnUndo.TabIndex = 14;
            this.btnUndo.Text = "PHỤC HỒI";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLuu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLuu.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseBorderColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.AppearanceDisabled.Options.UseFont = true;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Location = new System.Drawing.Point(507, 4);
            this.btnLuu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 40);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "GHI";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThem.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThem.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.AppearanceDisabled.Options.UseFont = true;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(193, 5);
            this.btnThem.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 40);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "ĐÓNG TIỀN";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnKhoa
            // 
            this.pnKhoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnKhoa.Controls.Add(this.cbKhoa);
            this.pnKhoa.Controls.Add(this.lbKhoa);
            this.pnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnKhoa.Location = new System.Drawing.Point(0, 53);
            this.pnKhoa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnKhoa.Name = "pnKhoa";
            this.pnKhoa.Size = new System.Drawing.Size(1582, 62);
            this.pnKhoa.TabIndex = 31;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKhoa.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(519, 4);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(391, 34);
            this.cbKhoa.TabIndex = 34;
            this.cbKhoa.ValueMember = "TENSERVER";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.Location = new System.Drawing.Point(438, 9);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(85, 31);
            this.lbKhoa.TabIndex = 33;
            this.lbKhoa.Text = "KHOA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMaSV);
            this.panel1.Controls.Add(mASVLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 100);
            this.panel1.TabIndex = 33;
            // 
            // cbMaSV
            // 
            this.cbMaSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_DONGHOCPHIBindingSource, "MASV", true));
            this.cbMaSV.DataSource = this.sINHVIENBindingSource;
            this.cbMaSV.DisplayMember = "MASV";
            this.cbMaSV.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(573, 29);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(261, 34);
            this.cbMaSV.TabIndex = 2;
            this.cbMaSV.ValueMember = "MASV";
            // 
            // cT_DONGHOCPHIBindingSource
            // 
            this.cT_DONGHOCPHIBindingSource.DataMember = "CT_DONGHOCPHI";
            this.cT_DONGHOCPHIBindingSource.DataSource = this.qLDSV_SERVER3;
            // 
            // qLDSV_SERVER3
            // 
            this.qLDSV_SERVER3.DataSetName = "QLDSV_SERVER3";
            this.qLDSV_SERVER3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSV_SERVER3;
            // 
            // cT_DONGHOCPHITableAdapter
            // 
            this.cT_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = this.cT_DONGHOCPHITableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_QLSV.QLDSV_SERVER3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDongHocPhi
            // 
            this.bdsDongHocPhi.DataMember = "SP_DONGHOCPHI";
            this.bdsDongHocPhi.DataSource = this.qLDSV_SERVER3;
            // 
            // sP_DONGHOCPHITableAdapter
            // 
            this.sP_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = CSDLPT_QLSV.QLDSV_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsDongHocPhi;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHocPhi.Font = new System.Drawing.Font("Trajan Pro 3", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcHocPhi.Location = new System.Drawing.Point(0, 215);
            this.gcHocPhi.MainView = this.gridView1;
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(1582, 233);
            this.gcHocPhi.TabIndex = 34;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Trajan Pro 3", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Teal;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trajan Pro 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Trajan Pro 3", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIÊNKHÓA,
            this.colHỌCKỲ,
            this.colHỌCPHÍ,
            this.colTIỀNĐÃĐÓNG,
            this.colSỐTIỀNĐÓNG});
            this.gridView1.GridControl = this.gcHocPhi;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 38;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // colNIÊNKHÓA
            // 
            this.colNIÊNKHÓA.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colNIÊNKHÓA.AppearanceCell.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIÊNKHÓA.AppearanceCell.Options.UseBorderColor = true;
            this.colNIÊNKHÓA.AppearanceCell.Options.UseFont = true;
            this.colNIÊNKHÓA.AppearanceCell.Options.UseTextOptions = true;
            this.colNIÊNKHÓA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIÊNKHÓA.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNIÊNKHÓA.AppearanceHeader.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIÊNKHÓA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIÊNKHÓA.AppearanceHeader.Options.UseFont = true;
            this.colNIÊNKHÓA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNIÊNKHÓA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIÊNKHÓA.FieldName = "NIÊN KHÓA";
            this.colNIÊNKHÓA.MinWidth = 15;
            this.colNIÊNKHÓA.Name = "colNIÊNKHÓA";
            this.colNIÊNKHÓA.Visible = true;
            this.colNIÊNKHÓA.VisibleIndex = 0;
            this.colNIÊNKHÓA.Width = 150;
            // 
            // colHỌCKỲ
            // 
            this.colHỌCKỲ.AppearanceCell.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHỌCKỲ.AppearanceCell.Options.UseFont = true;
            this.colHỌCKỲ.AppearanceCell.Options.UseTextOptions = true;
            this.colHỌCKỲ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHỌCKỲ.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHỌCKỲ.AppearanceHeader.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHỌCKỲ.AppearanceHeader.Options.UseBackColor = true;
            this.colHỌCKỲ.AppearanceHeader.Options.UseFont = true;
            this.colHỌCKỲ.AppearanceHeader.Options.UseTextOptions = true;
            this.colHỌCKỲ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHỌCKỲ.FieldName = "HỌC KỲ";
            this.colHỌCKỲ.MinWidth = 25;
            this.colHỌCKỲ.Name = "colHỌCKỲ";
            this.colHỌCKỲ.Visible = true;
            this.colHỌCKỲ.VisibleIndex = 1;
            this.colHỌCKỲ.Width = 106;
            // 
            // colHỌCPHÍ
            // 
            this.colHỌCPHÍ.AppearanceCell.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHỌCPHÍ.AppearanceCell.Options.UseFont = true;
            this.colHỌCPHÍ.AppearanceCell.Options.UseTextOptions = true;
            this.colHỌCPHÍ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHỌCPHÍ.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHỌCPHÍ.AppearanceHeader.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHỌCPHÍ.AppearanceHeader.Options.UseBackColor = true;
            this.colHỌCPHÍ.AppearanceHeader.Options.UseFont = true;
            this.colHỌCPHÍ.AppearanceHeader.Options.UseTextOptions = true;
            this.colHỌCPHÍ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHỌCPHÍ.FieldName = "HỌC PHÍ";
            this.colHỌCPHÍ.MinWidth = 25;
            this.colHỌCPHÍ.Name = "colHỌCPHÍ";
            this.colHỌCPHÍ.Visible = true;
            this.colHỌCPHÍ.VisibleIndex = 2;
            this.colHỌCPHÍ.Width = 424;
            // 
            // colTIỀNĐÃĐÓNG
            // 
            this.colTIỀNĐÃĐÓNG.AppearanceCell.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTIỀNĐÃĐÓNG.AppearanceCell.Options.UseFont = true;
            this.colTIỀNĐÃĐÓNG.AppearanceCell.Options.UseTextOptions = true;
            this.colTIỀNĐÃĐÓNG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTIỀNĐÃĐÓNG.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colTIỀNĐÃĐÓNG.AppearanceHeader.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTIỀNĐÃĐÓNG.AppearanceHeader.Options.UseBackColor = true;
            this.colTIỀNĐÃĐÓNG.AppearanceHeader.Options.UseFont = true;
            this.colTIỀNĐÃĐÓNG.AppearanceHeader.Options.UseTextOptions = true;
            this.colTIỀNĐÃĐÓNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTIỀNĐÃĐÓNG.FieldName = "TIỀN ĐÃ ĐÓNG";
            this.colTIỀNĐÃĐÓNG.MinWidth = 25;
            this.colTIỀNĐÃĐÓNG.Name = "colTIỀNĐÃĐÓNG";
            this.colTIỀNĐÃĐÓNG.Visible = true;
            this.colTIỀNĐÃĐÓNG.VisibleIndex = 3;
            this.colTIỀNĐÃĐÓNG.Width = 424;
            // 
            // colSỐTIỀNĐÓNG
            // 
            this.colSỐTIỀNĐÓNG.AppearanceCell.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSỐTIỀNĐÓNG.AppearanceCell.Options.UseFont = true;
            this.colSỐTIỀNĐÓNG.AppearanceCell.Options.UseTextOptions = true;
            this.colSỐTIỀNĐÓNG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSỐTIỀNĐÓNG.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSỐTIỀNĐÓNG.AppearanceHeader.Font = new System.Drawing.Font("Trajan Pro 3", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSỐTIỀNĐÓNG.AppearanceHeader.Options.UseBackColor = true;
            this.colSỐTIỀNĐÓNG.AppearanceHeader.Options.UseFont = true;
            this.colSỐTIỀNĐÓNG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSỐTIỀNĐÓNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSỐTIỀNĐÓNG.FieldName = "SỐ TIỀN ĐÓNG";
            this.colSỐTIỀNĐÓNG.MinWidth = 25;
            this.colSỐTIỀNĐÓNG.Name = "colSỐTIỀNĐÓNG";
            this.colSỐTIỀNĐÓNG.Visible = true;
            this.colSỐTIỀNĐÓNG.VisibleIndex = 4;
            this.colSỐTIỀNĐÓNG.Width = 448;
            // 
            // frmDongHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 636);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnKhoa);
            this.Controls.Add(this.pnTren);
            this.Name = "frmDongHocPhi";
            this.Text = "frmDongHocPhi";
            this.Load += new System.EventHandler(this.frmDongHocPhi_Load);
            this.pnTren.ResumeLayout(false);
            this.pnKhoa.ResumeLayout(false);
            this.pnKhoa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_DONGHOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_SERVER3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDongHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTren;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Panel pnKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Panel panel1;
        private QLDSV_SERVER3 qLDSV_SERVER3;
        private System.Windows.Forms.BindingSource cT_DONGHOCPHIBindingSource;
        private QLDSV_SERVER3TableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter;
        private QLDSV_SERVER3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsDongHocPhi;
        private QLDSV_SERVER3TableAdapters.SP_DONGHOCPHITableAdapter sP_DONGHOCPHITableAdapter;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSV_SERVER3TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private QLDSV_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIÊNKHÓA;
        private DevExpress.XtraGrid.Columns.GridColumn colHỌCKỲ;
        private DevExpress.XtraGrid.Columns.GridColumn colHỌCPHÍ;
        private DevExpress.XtraGrid.Columns.GridColumn colTIỀNĐÃĐÓNG;
        private DevExpress.XtraGrid.Columns.GridColumn colSỐTIỀNĐÓNG;
    }
}