namespace CSDLPT_QLSV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bBtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnClass = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnGrade = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnFee = new DevExpress.XtraBars.BarButtonItem();
            this.bBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.qldsV_DSPM1 = new CSDLPT_QLSV.QLDSV_DSPM();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.pnUser = new System.Windows.Forms.Panel();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.lbMaGVLogin = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbHoTenLogin = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.lbGroupLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_DSPM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.pnUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bBtnLogout,
            this.bBtnClass,
            this.bBtnStudent,
            this.bBtnSubject,
            this.bBtnGrade,
            this.bBtnFee,
            this.bBtnPrint});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1598, 235);
            // 
            // bBtnLogout
            // 
            this.bBtnLogout.Caption = "Đăng xuất";
            this.bBtnLogout.Id = 2;
            this.bBtnLogout.ImageOptions.Image = global::CSDLPT_QLSV.Properties.Resources.logout;
            this.bBtnLogout.ImageOptions.LargeImage = global::CSDLPT_QLSV.Properties.Resources.logout;
            this.bBtnLogout.Name = "bBtnLogout";
            // 
            // bBtnClass
            // 
            this.bBtnClass.Caption = "Lớp";
            this.bBtnClass.Id = 3;
            this.bBtnClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bBtnClass.ImageOptions.SvgImage")));
            this.bBtnClass.Name = "bBtnClass";
            // 
            // bBtnStudent
            // 
            this.bBtnStudent.Caption = "Sinh viên";
            this.bBtnStudent.Id = 4;
            this.bBtnStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bBtnStudent.ImageOptions.SvgImage")));
            this.bBtnStudent.Name = "bBtnStudent";
            this.bBtnStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBtnStudent_ItemClick);
            // 
            // bBtnSubject
            // 
            this.bBtnSubject.Caption = "Môn học";
            this.bBtnSubject.Id = 5;
            this.bBtnSubject.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bBtnSubject.ImageOptions.SvgImage")));
            this.bBtnSubject.Name = "bBtnSubject";
            // 
            // bBtnGrade
            // 
            this.bBtnGrade.Caption = "Điểm";
            this.bBtnGrade.Id = 6;
            this.bBtnGrade.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bBtnGrade.ImageOptions.SvgImage")));
            this.bBtnGrade.Name = "bBtnGrade";
            // 
            // bBtnFee
            // 
            this.bBtnFee.Caption = "Học phí";
            this.bBtnFee.Id = 7;
            this.bBtnFee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bBtnFee.ImageOptions.SvgImage")));
            this.bBtnFee.Name = "bBtnFee";
            // 
            // bBtnPrint
            // 
            this.bBtnPrint.Caption = "In ấn";
            this.bBtnPrint.Id = 8;
            this.bBtnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.bBtnPrint.Name = "bBtnPrint";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bBtnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bBtnClass);
            this.ribbonPageGroup2.ItemLinks.Add(this.bBtnStudent);
            this.ribbonPageGroup2.ItemLinks.Add(this.bBtnSubject);
            this.ribbonPageGroup2.ItemLinks.Add(this.bBtnGrade);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bBtnFee);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage4.Appearance.Options.UseFont = true;
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bBtnPrint);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // qldsV_DSPM1
            // 
            this.qldsV_DSPM1.DataSetName = "QLDSV_DSPM";
            this.qldsV_DSPM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // pnUser
            // 
            this.pnUser.Controls.Add(this.lbGroupLogin);
            this.pnUser.Controls.Add(this.lbGroup);
            this.pnUser.Controls.Add(this.lbHoTenLogin);
            this.pnUser.Controls.Add(this.lbHoTen);
            this.pnUser.Controls.Add(this.lbMaGVLogin);
            this.pnUser.Controls.Add(this.lbMaGV);
            this.pnUser.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.pnUser.Location = new System.Drawing.Point(0, 858);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(1598, 43);
            this.pnUser.TabIndex = 2;
            // 
            // lbMaGV
            // 
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Location = new System.Drawing.Point(12, 9);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(78, 23);
            this.lbMaGV.TabIndex = 0;
            this.lbMaGV.Text = "Mã GV:";
            // 
            // lbMaGVLogin
            // 
            this.lbMaGVLogin.AutoSize = true;
            this.lbMaGVLogin.Location = new System.Drawing.Point(91, 9);
            this.lbMaGVLogin.Name = "lbMaGVLogin";
            this.lbMaGVLogin.Size = new System.Drawing.Size(0, 23);
            this.lbMaGVLogin.TabIndex = 1;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(206, 9);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(73, 23);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // lbHoTenLogin
            // 
            this.lbHoTenLogin.AutoSize = true;
            this.lbHoTenLogin.Location = new System.Drawing.Point(287, 9);
            this.lbHoTenLogin.Name = "lbHoTenLogin";
            this.lbHoTenLogin.Size = new System.Drawing.Size(0, 23);
            this.lbHoTenLogin.TabIndex = 3;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(607, 9);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(71, 23);
            this.lbGroup.TabIndex = 4;
            this.lbGroup.Text = "Group:";
            // 
            // lbGroupLogin
            // 
            this.lbGroupLogin.AutoSize = true;
            this.lbGroupLogin.Location = new System.Drawing.Point(681, 9);
            this.lbGroupLogin.Name = "lbGroupLogin";
            this.lbGroupLogin.Size = new System.Drawing.Size(0, 23);
            this.lbGroupLogin.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 899);
            this.Controls.Add(this.pnUser);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_DSPM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.pnUser.ResumeLayout(false);
            this.pnUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bBtnLogout;
        private DevExpress.XtraBars.BarButtonItem bBtnClass;
        private DevExpress.XtraBars.BarButtonItem bBtnStudent;
        private DevExpress.XtraBars.BarButtonItem bBtnSubject;
        private DevExpress.XtraBars.BarButtonItem bBtnGrade;
        private DevExpress.XtraBars.BarButtonItem bBtnFee;
        private DevExpress.XtraBars.BarButtonItem bBtnPrint;
        private QLDSV_DSPM qldsV_DSPM1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Label lbGroupLogin;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.Label lbHoTenLogin;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaGVLogin;
        private System.Windows.Forms.Label lbMaGV;
    }
}

