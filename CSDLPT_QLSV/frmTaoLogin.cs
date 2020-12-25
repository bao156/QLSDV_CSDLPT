using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QLSV
{
    public partial class frmTaoLogin : Form
    {
        int currentIndex = 0;

        public frmTaoLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            cbNhom.DisplayMember = "Text";
            cbNhom.ValueMember = "Value";
            if (Program.mGroup == "PGV")
            {
                cbNhom.Items.Add(new { Text = "Phòng giáo vụ", Value = "PGV" });
                cbNhom.Items.Add(new { Text = "Khoa", Value = "Khoa" });
                cbNhom.Items.Add(new { Text = "User", Value = "User" });
            }
            else if (Program.mGroup == "Khoa")
            {
                cbNhom.Items.Add(new { Text = "Khoa", Value = "Khoa" });
                cbNhom.Items.Add(new { Text = "User", Value = "User" });
            }
            else
            {
                cbNhom.Items.Add(new { Text = "Phòng kế toán", Value = "PKeToan" });
            }

        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;

            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);

            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
            cbKhoa.SelectedIndex = Program.mChinhanh;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedIndex == 2)
            {
                MessageBox.Show("Bạn không thể vào site này", "Cảnh báo!", MessageBoxButtons.OK);
                cbKhoa.SelectedIndex = currentIndex;
                return;
            }
            else
            {
                currentIndex = cbKhoa.SelectedIndex;
                if (cbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cbKhoa.SelectedValue.ToString();
                }
                if (cbKhoa.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi chuyển cơ sở", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmTaoLogin_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String login = txtMaGV.Text.Trim();
            String password = txtPassword.Text.Trim();
            String maGV = txtMaGV.Text.Trim();
            Object obNhom = cbNhom.SelectedItem;
            String nhom = "";
            

            if (login == "")
            {
                MessageBox.Show("Username không được bỏ trống");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Password không được bỏ trống");
                return;
            }

            if (maGV == "")
            {
                MessageBox.Show("Mã giảng viên không được bỏ trống");
                return;
            }

            if (obNhom == null)
            {
                MessageBox.Show("Bạn chưa nhóm quyền");
                return;
            }
            else
            {
                nhom = cbNhom.Text.ToString().Trim();
            }

            if (Program.KetNoi() == 0) return;
            String str = "dbo.SP_CHECKMAGV";
            Program.cmd = Program.conn.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = str;
            Program.cmd.Parameters.Add("@MAGV", SqlDbType.NChar).Value = maGV;
            Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.cmd.ExecuteNonQuery();
            int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
            Console.WriteLine(result);
            if (result != 1)
            {
                MessageBox.Show("Giảng viên không tồn tại");
                return;
            }

            try
            {

                String str2 = "dbo.SP_TAOTAIKHOAN";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str2;
                Program.cmd.Parameters.Add("@LGNAME", SqlDbType.NChar).Value = login;
                Program.cmd.Parameters.Add("@PASS", SqlDbType.NChar).Value = password;
                Program.cmd.Parameters.Add("@USERNAME", SqlDbType.NChar).Value = maGV;
                Program.cmd.Parameters.Add("@ROLE", SqlDbType.NChar).Value = nhom;
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                Program.cmd.CommandText = "ErrorHandle";
                MessageBox.Show("Tạo tài khoản thành công");
                btnReload_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
    }
}
