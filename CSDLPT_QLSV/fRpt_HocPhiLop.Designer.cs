namespace CSDLPT_QLSV
{
    partial class fRpt_HocPhiLop
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tENLOPLabel;
            this.pnGiua = new System.Windows.Forms.Panel();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.bds = new CSDLPT_QLSV.QLDSV_SERVER3();
            this.lOPTableAdapter = new CSDLPT_QLSV.QLDSV_SERVER3TableAdapters.LOPTableAdapter();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            this.pnGiua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(433, 255);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 25);
            label2.TabIndex = 41;
            label2.Text = "Học kỳ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(415, 166);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 25);
            label1.TabIndex = 39;
            label1.Text = "Niên khóa:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            tENLOPLabel.Location = new System.Drawing.Point(433, 81);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(98, 25);
            tENLOPLabel.TabIndex = 37;
            tENLOPLabel.Text = "Tên lớp: ";
            // 
            // pnGiua
            // 
            this.pnGiua.Controls.Add(this.cbHocKy);
            this.pnGiua.Controls.Add(this.btnThoat);
            this.pnGiua.Controls.Add(this.btnBaoCao);
            this.pnGiua.Controls.Add(label2);
            this.pnGiua.Controls.Add(label1);
            this.pnGiua.Controls.Add(this.cbNienKhoa);
            this.pnGiua.Controls.Add(tENLOPLabel);
            this.pnGiua.Controls.Add(this.cbMaLop);
            this.pnGiua.Location = new System.Drawing.Point(1, -1);
            this.pnGiua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnGiua.Name = "pnGiua";
            this.pnGiua.Size = new System.Drawing.Size(1402, 437);
            this.pnGiua.TabIndex = 2;
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKy.Location = new System.Drawing.Point(558, 255);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(116, 30);
            this.cbHocKy.TabIndex = 48;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(845, 362);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 34);
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
            this.btnBaoCao.Location = new System.Drawing.Point(438, 362);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(125, 34);
            this.btnBaoCao.TabIndex = 46;
            this.btnBaoCao.Text = "In báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.DisplayMember = "TENMH";
            this.cbNienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Items.AddRange(new object[] {
            "2019-2020",
            "2018-2019",
            "2017-2018",
            "2016-2017",
            "2015-2016",
            "2014-2015",
            "2013-2014",
            "2012-2013",
            "2011-2012",
            "2010-2011",
            "2009-2010",
            "2008-2009",
            "2007-2008",
            "2006-2007",
            "2005-2006",
            "2004-2005",
            "2003-2004",
            "2002-2003",
            "2001-2002",
            "2000-2001"});
            this.cbNienKhoa.Location = new System.Drawing.Point(558, 166);
            this.cbNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(391, 30);
            this.cbNienKhoa.TabIndex = 40;
            this.cbNienKhoa.ValueMember = "MAMH";
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataSource = this.bdsLop;
            this.cbMaLop.DisplayMember = "TENLOP";
            this.cbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(558, 81);
            this.cbMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(391, 30);
            this.cbMaLop.TabIndex = 38;
            this.cbMaLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.bds;
            // 
            // bds
            // 
            this.bds.DataSetName = "QLDSV_SERVER3";
            this.bds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // fRpt_HocPhiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 435);
            this.Controls.Add(this.pnGiua);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fRpt_HocPhiLop";
            this.Text = "Report Học phí lớp";
            this.Load += new System.EventHandler(this.fRpt_HocPhiLop_Load);
            this.pnGiua.ResumeLayout(false);
            this.pnGiua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGiua;
        private System.Windows.Forms.ComboBox cbHocKy;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private System.Windows.Forms.ComboBox cbMaLop;
        private QLDSV_SERVER3 bds;
        private System.Windows.Forms.BindingSource bdsLop;
        private QLDSV_SERVER3TableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}