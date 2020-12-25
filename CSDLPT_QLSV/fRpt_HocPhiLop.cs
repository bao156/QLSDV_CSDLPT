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
    public partial class fRpt_HocPhiLop : Form
    {
        public fRpt_HocPhiLop()
        {
            InitializeComponent();
        }

        private void fRpt_HocPhiLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_SERVER3.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.bds.LOP);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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
            MessageBox.Show(maLop);
            Object obNienKhoa = cbNienKhoa.SelectedItem;
            String nienKhoa = "";
            if (obNienKhoa == null)
            {
                nienKhoa = cbNienKhoa.Text;
                if (nienKhoa == "")
                {
                    MessageBox.Show("Bạn chưa chọn/nhập niên khóa");
                }
                else nienKhoa = cbNienKhoa.Text;
            }
            else
            {
                nienKhoa = obNienKhoa.ToString();
            }

            Object obHocKy = cbHocKy.SelectedItem;
            String hocKy = "";
            if (obHocKy == null)
            {
                hocKy = cbHocKy.Text;
                if (hocKy == "")
                {
                    MessageBox.Show("Bạn chưa chọn/nhập học kỳ");
                }
                else hocKy = cbHocKy.Text;
            }
            else
            {
                hocKy = obHocKy.ToString();
            }
 
            Xrpt_HocPhiLop rpt = new Xrpt_HocPhiLop(maLop, nienKhoa, int.Parse(hocKy));
            rpt.tCellNienKhoa.Text = nienKhoa;
            rpt.tCellHocKy.Text = hocKy;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
