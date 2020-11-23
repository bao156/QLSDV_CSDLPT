namespace CSDLPT_QLSV
{
    partial class frmDangNhap
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
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.qLDSV_DSPM = new CSDLPT_QLSV.QLDSV_DSPM();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter1 = new CSDLPT_QLSV.QLDSV_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new CSDLPT_QLSV.QLDSV_DSPMTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(464, 54);
            this.lbDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(676, 132);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbTaiKhoan);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbTaiKhoan);
            this.panel1.Controls.Add(this.lbChiNhanh);
            this.panel1.Controls.Add(this.cbTenKhoa);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(584, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 426);
            this.panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLogin.FlatAppearance.BorderSize = 30;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::CSDLPT_QLSV.Properties.Resources._checked;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(372, 307);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 54);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(248, 227);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(460, 39);
            this.tbPassword.TabIndex = 5;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaiKhoan.Location = new System.Drawing.Point(248, 118);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(460, 39);
            this.tbTaiKhoan.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(94, 231);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(130, 32);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(81, 118);
            this.lbTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(145, 32);
            this.lbTaiKhoan.TabIndex = 2;
            this.lbTaiKhoan.Text = "Tài Khoản";
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(184, 34);
            this.lbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(82, 32);
            this.lbChiNhanh.TabIndex = 1;
            this.lbChiNhanh.Text = "Khoa";
            this.lbChiNhanh.Click += new System.EventHandler(this.lbChiNhanh_Click);
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.DataSource = this.bdsPM;
            this.cbTenKhoa.DisplayMember = "TENKHOA";
            this.cbTenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(306, 34);
            this.cbTenKhoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(374, 33);
            this.cbTenKhoa.TabIndex = 0;
            this.cbTenKhoa.ValueMember = "TENSERVER";
            // 
            // label5
            // 
            this.label5.Image = global::CSDLPT_QLSV.Properties.Resources.login_icon;
            this.label5.Location = new System.Drawing.Point(22, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(554, 427);
            this.label5.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Image = global::CSDLPT_QLSV.Properties.Resources.Close_icon;
            this.btClose.Location = new System.Drawing.Point(1407, 3);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(54, 47);
            this.btClose.TabIndex = 3;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMinimize.Image = global::CSDLPT_QLSV.Properties.Resources.Programming_Minimize_Window_icon1;
            this.btMinimize.Location = new System.Drawing.Point(1332, 3);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(68, 47);
            this.btMinimize.TabIndex = 4;
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.button3_Click);
            // 
            // qLDSV_DSPM
            // 
            this.qLDSV_DSPM.DataSetName = "QLDSV_DSPM";
            this.qLDSV_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.qLDSV_DSPM;
            // 
            // v_DS_PHANMANHTableAdapter1
            // 
            this.v_DS_PHANMANHTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = CSDLPT_QLSV.QLDSV_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 699);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.ComboBox cbTenKhoa;
        private QLDSV_DSPM qLDSV_DSPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private QLDSV_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter1;
        private QLDSV_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

