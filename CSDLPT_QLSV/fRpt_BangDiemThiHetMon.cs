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
    public partial class fRpt_BangDiemThiHetMon : Form
    {
        int currentIndex = 0;

        public fRpt_BangDiemThiHetMon()
        {
            InitializeComponent();
        }

        private void fRpt_BangDiemThiHetMon_Load(object sender, EventArgs e)
        {
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;

            // TODO: This line of code loads data into the 'qldsV_DSPM1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSV_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.bds.LOP);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.bds.MONHOC);

            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
            cbKhoa.SelectedIndex = Program.mChinhanh;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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

                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.bds.MONHOC);
                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            String maLop = "";
            Object obMaLop = cbMaLop.SelectedItem;
            if (obMaLop == null)
            {
                maLop = cbMaLop.SelectedValue.ToString().Trim();
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
                maMon = cbMaMon.SelectedValue.ToString().Trim();
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

            String ngayThi = dateEditNT.EditValue.ToString();
            if (ngayThi == "")
            {
                MessageBox.Show("Ngày thi không được bỏ trống");
            }

            Object obLanThi = cbLanThi.SelectedItem;
            String lanThi = "";
            if (obLanThi == null)
            {
                lanThi = cbLanThi.Text;
                if (lanThi == "")
                {
                    MessageBox.Show("Bạn chưa chọn/nhập lần thi");
                }
                else lanThi = cbLanThi.Text;
            }
            else
            {
                lanThi = obLanThi.ToString();
            }
            Console.WriteLine(maLop);
            Console.WriteLine(maMon);
            Console.WriteLine(int.Parse(lanThi));

            Xrpt_BangDiemThiHetMon rpt = new Xrpt_BangDiemThiHetMon(maLop,maMon,int.Parse(lanThi));
            rpt.tCellLop.Text = cbMaLop.Text;
            rpt.tCellMon.Text = cbMaMon.Text;
            rpt.tCellLanThi.Text = lanThi;
            rpt.tCellNgayThi.Text = ngayThi;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
