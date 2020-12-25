using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QLSV
{
    public partial class frmDiem : Form
    {
        int currentIndex;
        public frmDiem()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bds);

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_SERVER1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.bds.MONHOC);
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            bds.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.bds.LOP);
            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
            cbKhoa.SelectedIndex = Program.mChinhanh;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbKhoa.Enabled = false;
            String maLop = "";
            Object obMaLop = cbMaLop.SelectedItem;
            if (obMaLop == null)
            {
                maLop = cbMaLop.Text.Trim();
                if (maLop == "")
                {
                    MessageBox.Show("Bạn chưa nhập/chọn lớp");
                    return;
                }
                else
                {
                    if (Program.KetNoi() == 0) return;
                    String str = "dbo.SP_CHECKMALOP";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str;
                    Program.cmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = maLop;
                    Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.cmd.ExecuteNonQuery();
                    int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                    if (result != 1)
                    {
                        MessageBox.Show("Lớp không tồn tại");
                        return;
                    }
                }
            }
            else
            {
                maLop = cbMaLop.SelectedValue.ToString().Trim();
            }
            
            String maMon = "";
            Object obMaMon = cbMaMon.SelectedItem;
            if (obMaMon == null)
            {
                maMon = cbMaMon.Text.Trim();
                if (maMon == "")
                {
                    MessageBox.Show("Bạn chưa nhập/chọn môn");
                    return;
                }
                else
                {
                    if (Program.KetNoi() == 0) return;
                    String str = "dbo.SP_CHECKMAMH";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str;
                    Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMon;
                    Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.cmd.ExecuteNonQuery();
                    int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                    if (result != 1)
                    {
                        MessageBox.Show("Mã môn không tồn tại");
                        return;
                    }
                }
            }
            else
            {
                maMon = cbMaMon.SelectedValue.ToString().Trim();
            }

            Object obLanThi = cbLanThi.SelectedItem;
            String lanThi = "";
            gridView1.Columns[3].OptionsColumn.ReadOnly = false;
            gcDiem.Enabled = true;
            if (obLanThi == null)
            {
                MessageBox.Show("Bạn chưa chọn lần thi");
                return;
            }
            else if (obLanThi == "1")
            {
                lanThi = obLanThi.ToString();
                if (Program.KetNoi() == 0) return;
                String str = "dbo.SP_NHAPDIEM";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str;
                Program.cmd.Parameters.AddWithValue("@MALOP", maLop);
                Program.cmd.Parameters.AddWithValue("@MAMH", maMon);
                Program.cmd.Parameters.AddWithValue("@LAN", lanThi);
                SqlDataAdapter da = new SqlDataAdapter(Program.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bdsNhapDiem.DataSource = dt;
                gridView1.Columns[0].OptionsColumn.ReadOnly = true;
                gridView1.Columns[1].OptionsColumn.ReadOnly = true;
                gridView1.Columns[2].OptionsColumn.ReadOnly = true;


                String len = "dbo.SP_CHECKKHOADIEM";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = len;
                Program.cmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = maLop;
                Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMon;
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                if (result == 1)
                {
                    gridView1.Columns[3].OptionsColumn.ReadOnly = true;
                }
            }
            else
            {
                if (Program.KetNoi() == 0) return;
                String len = "dbo.SP_CHECKTHI";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = len;
                Program.cmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = maLop;
                Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMon;
                Program.cmd.Parameters.AddWithValue("@LAN", "1");
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                if (result == 0)
                {
                    MessageBox.Show("CHƯA THI LẦN 1! VUI LÒNG NHẬP ĐIỂM LẦN 1");
                }
                if (result == 1)
                {
                    lanThi = obLanThi.ToString();
                    if (Program.KetNoi() == 0) return;
                    String str = "dbo.SP_NHAPDIEM_LAN2";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str;
                    Program.cmd.Parameters.AddWithValue("@MALOP", maLop);
                    Program.cmd.Parameters.AddWithValue("@MAMH", maMon);
                    Program.cmd.Parameters.AddWithValue("@LAN", lanThi);
                    SqlDataAdapter da = new SqlDataAdapter(Program.cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bdsNhapDiem.DataSource = dt;
                    gridView1.Columns[0].OptionsColumn.ReadOnly = true;
                    gridView1.Columns[1].OptionsColumn.ReadOnly = true;
                    gridView1.Columns[2].OptionsColumn.ReadOnly = true;
                }
            }
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < bdsNhapDiem.Count; i++)
            {
                string dataDiem = ((DataRowView)bdsNhapDiem[i])["DIEM"].ToString().Trim();
                if (float.Parse(dataDiem)>10 || float.Parse(dataDiem)<0)
                {
                    check = false;
                    MessageBox.Show("ĐIỂM KHÔNG HỢP LỆ");
                    break;
                }    
            }


            if(check==true)
            {
                for (int i = 0; i < bdsNhapDiem.Count; i++)
                {
                    if (Program.KetNoi() == 0) return;
                    string dataDiem = ((DataRowView)bdsNhapDiem[i])["DIEM"].ToString().Trim();
                    float diem = 0;
                    if (dataDiem != "")
                    {
                        diem = float.Parse(((DataRowView)bdsNhapDiem[i])["DIEM"].ToString().Trim());
                    }
                    String str = "dbo.SP_LUUDIEM";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str;
                    Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = ((DataRowView)bdsNhapDiem[i])["MASV"].ToString().Trim();
                    Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = cbMaMon.SelectedValue.ToString().Trim();
                    Program.cmd.Parameters.Add("@LAN", SqlDbType.Int).Value = int.Parse(cbLanThi.SelectedItem.ToString().Trim());
                    Program.cmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
                    Program.cmd.ExecuteNonQuery();

                }
                MessageBox.Show("NHẬP ĐIỂM THÀNH CÔNG");
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            cbKhoa.Enabled = true;

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
                else
                {
                    bds.EnforceConstraints = false;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.bds.LOP);

                }
            }
        }
    }
}
