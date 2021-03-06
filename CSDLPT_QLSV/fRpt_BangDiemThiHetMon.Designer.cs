﻿namespace CSDLPT_QLSV
{
    partial class fRpt_BangDiemThiHetMon
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.pnGiua = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditNT = new DevExpress.XtraEditors.DateEdit();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.bdsMon = new System.Windows.Forms.BindingSource(this.components);
            this.bds = new CSDLPT_QLSV.QLDSV_SERVER1();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_DSPM = new CSDLPT_QLSV.QLDSV_DSPM();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHTableAdapter = new CSDLPT_QLSV.QLDSV_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.lOPTableAdapter = new CSDLPT_QLSV.QLDSV_SERVER1TableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new CSDLPT_QLSV.QLDSV_SERVER1TableAdapters.MONHOCTableAdapter();
            tENLOPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.pnGiua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            tENLOPLabel.Location = new System.Drawing.Point(510, 125);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(117, 29);
            tENLOPLabel.TabIndex = 37;
            tENLOPLabel.Text = "Tên lớp: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(510, 196);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 29);
            label1.TabIndex = 39;
            label1.Text = "Môn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(510, 275);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 29);
            label2.TabIndex = 41;
            label2.Text = "Ngày thi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(510, 343);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 29);
            label3.TabIndex = 43;
            label3.Text = "Lần:";
            // 
            // pnGiua
            // 
            this.pnGiua.Controls.Add(this.btnThoat);
            this.pnGiua.Controls.Add(this.btnBaoCao);
            this.pnGiua.Controls.Add(this.dateEditNT);
            this.pnGiua.Controls.Add(label3);
            this.pnGiua.Controls.Add(this.cbLanThi);
            this.pnGiua.Controls.Add(label2);
            this.pnGiua.Controls.Add(label1);
            this.pnGiua.Controls.Add(this.cbMaMon);
            this.pnGiua.Controls.Add(tENLOPLabel);
            this.pnGiua.Controls.Add(this.cbMaLop);
            this.pnGiua.Controls.Add(this.cbKhoa);
            this.pnGiua.Controls.Add(this.lbKhoa);
            this.pnGiua.Location = new System.Drawing.Point(0, -2);
            this.pnGiua.Name = "pnGiua";
            this.pnGiua.Size = new System.Drawing.Size(1577, 546);
            this.pnGiua.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(951, 455);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 43);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnBaoCao.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.Appearance.Options.UseBackColor = true;
            this.btnBaoCao.Appearance.Options.UseFont = true;
            this.btnBaoCao.Location = new System.Drawing.Point(493, 455);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(141, 43);
            this.btnBaoCao.TabIndex = 46;
            this.btnBaoCao.Text = "In báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dateEditNT
            // 
            this.dateEditNT.EditValue = null;
            this.dateEditNT.Location = new System.Drawing.Point(628, 270);
            this.dateEditNT.Name = "dateEditNT";
            this.dateEditNT.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dateEditNT.Properties.Appearance.Options.UseFont = true;
            this.dateEditNT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNT.Size = new System.Drawing.Size(439, 32);
            this.dateEditNT.TabIndex = 45;
            // 
            // cbLanThi
            // 
            this.cbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(628, 342);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(130, 34);
            this.cbLanThi.TabIndex = 44;
            // 
            // cbMaMon
            // 
            this.cbMaMon.DataSource = this.bdsMon;
            this.cbMaMon.DisplayMember = "TENMH";
            this.cbMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Location = new System.Drawing.Point(628, 195);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(439, 34);
            this.cbMaMon.TabIndex = 40;
            this.cbMaMon.ValueMember = "MAMH";
            // 
            // bdsMon
            // 
            this.bdsMon.DataMember = "MONHOC";
            this.bdsMon.DataSource = this.bds;
            // 
            // bds
            // 
            this.bds.DataSetName = "QLDSV_SERVER1";
            this.bds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataSource = this.bdsLop;
            this.cbMaLop.DisplayMember = "TENLOP";
            this.cbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(628, 124);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(439, 34);
            this.cbMaLop.TabIndex = 38;
            this.cbMaLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.bds;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DataSource = this.bdsPM;
            this.cbKhoa.DisplayMember = "TENKHOA";
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(628, 47);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(439, 34);
            this.cbKhoa.TabIndex = 36;
            this.cbKhoa.ValueMember = "TENSERVER";
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.qLDSV_DSPM;
            // 
            // qLDSV_DSPM
            // 
            this.qLDSV_DSPM.DataSetName = "QLDSV_DSPM";
            this.qLDSV_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbKhoa.Location = new System.Drawing.Point(510, 52);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(91, 29);
            this.lbKhoa.TabIndex = 35;
            this.lbKhoa.Text = "KHOA:";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // fRpt_BangDiemThiHetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 544);
            this.Controls.Add(this.pnGiua);
            this.Name = "fRpt_BangDiemThiHetMon";
            this.Text = "Report Bảng điểm thi hết môn";
            this.Load += new System.EventHandler(this.fRpt_BangDiemThiHetMon_Load);
            this.pnGiua.ResumeLayout(false);
            this.pnGiua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_DSPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGiua;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.ComboBox cbLanThi;
        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.ComboBox cbMaLop;
        private QLDSV_DSPM qLDSV_DSPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private QLDSV_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSV_SERVER1 bds;
        private System.Windows.Forms.BindingSource bdsLop;
        private QLDSV_SERVER1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsMon;
        private QLDSV_SERVER1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.DateEdit dateEditNT;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
    }
}