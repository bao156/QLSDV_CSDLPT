using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSDLPT_QLSV
{
    public partial class frmDangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            tbPassword.PasswordChar = '*';
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter1.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void lbChiNhanh_Click(object sender, EventArgs e)
        {

        }
        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbTenKhoa.SelectedValue.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbTaiKhoan.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được bỏ trống");
                return;
            }
            Program.mlogin = tbTaiKhoan.Text.Trim();
            Program.password = tbPassword.Text.Trim();
            Program.servername = cbTenKhoa.SelectedValue.ToString();

            if (Program.KetNoi() == 0) return;

            
            Program.mChinhanh = cbTenKhoa.SelectedIndex;
            Console.WriteLine(Program.mChinhanh);
            Program.bds_dspm = bdsPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu");
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Form frm = this.CheckExists(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }

            Program.myReader.Close();
            Program.conn.Close();

            //Program.frmChinh.MAGV.Text = "Mã GV = " + Program.username;
            //Program.frmChinh.HoTen.Text = "Họ tên= " + Program.mHoten;
            //Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
            //Program.frmChinh.HienThiMenu();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (tbTaiKhoan.Text.Trim() == "" || tbPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được bỏ trống");
                    return;
                }
                Program.mlogin = tbTaiKhoan.Text.Trim();
                Program.password = tbPassword.Text.Trim();
                Program.servername = cbTenKhoa.SelectedValue.ToString();

                if (Program.KetNoi() == 0) return;


                Program.mChinhanh = cbTenKhoa.SelectedIndex;
                Console.WriteLine(Program.mChinhanh);
                Program.bds_dspm = bdsPM;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn không có quyền truy cập dữ liệu");
                    return;
                }

                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Form frm = this.CheckExists(typeof(frmMain));
                if (frm != null) frm.Activate();
                else
                {
                    this.Hide();
                    frmMain f = new frmMain();
                    f.Show();
                }

                Program.myReader.Close();
                Program.conn.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
