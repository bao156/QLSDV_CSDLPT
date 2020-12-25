using CSDLPT_QLSV.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace CSDLPT_QLSV
{
    public partial class fRpt_DanhSachSinhVien : Form
    {
        int currentIndex = 0;

        public fRpt_DanhSachSinhVien()
        {
            InitializeComponent();
        }


        private void fRpt_DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            bds.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qldsV_DSPM1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSV_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.bds.LOP);

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
                else
                {
                    bds.EnforceConstraints = false;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.bds.LOP);
                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
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

            Xrpt_DanhSachSinhVien rpt = new Xrpt_DanhSachSinhVien(maLop);
            rpt.tCellLop.Text = cbMaLop.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
