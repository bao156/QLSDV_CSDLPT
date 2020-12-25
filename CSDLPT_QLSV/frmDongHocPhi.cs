using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QLSV
{
    public partial class frmDongHocPhi : Form
    {
        int currentIndex = 0;
        


        public frmDongHocPhi()
        {
            InitializeComponent();
            cbMaSV.SelectedIndex = -1;
            btnLuu.Enabled = false;
        }

        private void cT_DONGHOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cT_DONGHOCPHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_SERVER3);

        }

        private void frmDongHocPhi_Load(object sender, EventArgs e)
        {
           
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            qLDSV_SERVER3.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_SERVER3.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.cT_DONGHOCPHITableAdapter.Fill(this.qLDSV_SERVER3.CT_DONGHOCPHI);
            // TODO: This line of code loads data into the 'qLDSV_SERVER3.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSV_SERVER3.SINHVIEN);
            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            String maSV = cbMaSV.SelectedValue.ToString().Trim();
            try
            {
                if (Program.KetNoi() == 0) return;
                String str = "dbo.SP_DONGHOCPHI";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str;
                Program.cmd.Parameters.AddWithValue("@MASV", maSV);
                SqlDataAdapter da = new SqlDataAdapter(Program.cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bdsDongHocPhi.DataSource = dt;

                for (int i = 0; i < bdsDongHocPhi.Count; i++)
                {
                    if (((DataRowView)bdsDongHocPhi[i])["TIỀN ĐÃ ĐÓNG"].ToString().Trim() == "")
                    {
                        ((DataRowView)bdsDongHocPhi[i])["TIỀN ĐÃ ĐÓNG"] = 0;
                    }
                    if (int.Parse(((DataRowView)bdsDongHocPhi[i])["HỌC PHÍ"].ToString().Trim()) == int.Parse(((DataRowView)bdsDongHocPhi[i])["TIỀN ĐÃ ĐÓNG"].ToString().Trim()))
                    {

                    }
                }
                gridView1.Columns[0].OptionsColumn.ReadOnly = true;
                gridView1.Columns[1].OptionsColumn.ReadOnly = true;
                gridView1.Columns[2].OptionsColumn.ReadOnly = true;
                gridView1.Columns[3].OptionsColumn.ReadOnly = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            String maSV = cbMaSV.Text.Trim();
            String nienKhoa;
            int hocKy;
            int hocPhi;
            int dataTienDaDong;
            int dataTienDong;
            bool check = true;
            for (int j = 0; j < bdsDongHocPhi.Count; j++)
            {
                nienKhoa = ((DataRowView)bdsDongHocPhi[j])["NIÊN KHÓA"].ToString().Trim();
                hocKy = int.Parse(((DataRowView)bdsDongHocPhi[j])["HỌC KỲ"].ToString().Trim());
                hocPhi = int.Parse(((DataRowView)bdsDongHocPhi[j])["HỌC PHÍ"].ToString().Trim());
                dataTienDaDong = int.Parse(((DataRowView)bdsDongHocPhi[j])["TIỀN ĐÃ ĐÓNG"].ToString().Trim());
                dataTienDong = int.Parse(((DataRowView)bdsDongHocPhi[j])["SỐ TIỀN ĐÓNG"].ToString().Trim());
                check = true;
                if (dataTienDong < 0)
                {
                    MessageBox.Show("TIỀN ĐÓNG KHÔNG HỢP LỆ! VUI LÒNG NHẬP LẠI ");
                    check = false;
                    break;
                }
                else if ((dataTienDaDong + dataTienDong) > hocPhi)
                {
                    MessageBox.Show("[KỲ " + int.Parse(((DataRowView)bdsDongHocPhi[j])["HỌC KỲ"].ToString().Trim()) + "\nNIÊN KHÓA:" + ((DataRowView)bdsDongHocPhi[j])["NIÊN KHÓA"].ToString().Trim()+ "]\nSỐ TIỀN ĐÓNG VƯỢT QUA HỌC PHÍ!");
                    check = false;
                    break;
                }
                else
                {
                    if (Program.KetNoi() == 0) return;
                    String str = "dbo.SP_CHECKDONGHOCPHI";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str;
                    Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                    Program.cmd.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienKhoa;
                    Program.cmd.Parameters.Add("@HOCKY", SqlDbType.Int).Value = hocKy;
                    Program.cmd.Parameters.Add("@NGAY", SqlDbType.NChar).Value = DateTime.Now.ToString("yyyy-MM-dd"); ;
                    Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.cmd.ExecuteNonQuery();
                    int result1 = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                    if (result1 == 1)
                    {
                        MessageBox.Show("[KỲ " + int.Parse(((DataRowView)bdsDongHocPhi[j])["HỌC KỲ"].ToString().Trim()) + "\tNIÊN KHÓA:" + ((DataRowView)bdsDongHocPhi[j])["NIÊN KHÓA"].ToString().Trim()+"]\n HÔM NAY ĐÃ ĐÓNG");
                        check = false;
                        break;
                    }
                }
            }
            if (check == true)
            {
                for (int i = 0; i < bdsDongHocPhi.Count; i++)
                {
                    nienKhoa = ((DataRowView)bdsDongHocPhi[i])["NIÊN KHÓA"].ToString().Trim();
                    hocKy = int.Parse(((DataRowView)bdsDongHocPhi[i])["HỌC KỲ"].ToString().Trim());
                    hocPhi = int.Parse(((DataRowView)bdsDongHocPhi[i])["HỌC PHÍ"].ToString().Trim());
                    dataTienDaDong = int.Parse(((DataRowView)bdsDongHocPhi[i])["TIỀN ĐÃ ĐÓNG"].ToString().Trim());
                    dataTienDong = int.Parse(((DataRowView)bdsDongHocPhi[i])["SỐ TIỀN ĐÓNG"].ToString().Trim());
                    if (dataTienDong > 0)
                    {
                        if (Program.KetNoi() == 0) return;
                        String len = "dbo.SP_LUUDONGHOCPHI";
                        Program.cmd = Program.conn.CreateCommand();
                        Program.cmd.CommandType = CommandType.StoredProcedure;
                        Program.cmd.CommandText = len;
                        Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                        Program.cmd.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienKhoa;
                        Program.cmd.Parameters.Add("@HOCKY", SqlDbType.Int).Value = hocKy;
                        Program.cmd.Parameters.Add("@NGAY", SqlDbType.NChar).Value = DateTime.Now.ToString("yyyy-MM-dd"); ;
                        Program.cmd.Parameters.Add("@TIENDONG", SqlDbType.Int).Value = dataTienDong;
                        Program.cmd.ExecuteNonQuery();

                    }

                }
                MessageBox.Show("ĐÓNG TIỀN THÀNH CÔNG");
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }

        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            this.cT_DONGHOCPHITableAdapter.Fill(this.qLDSV_SERVER3.CT_DONGHOCPHI);
        }


        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            int hocPhi = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colHỌCPHÍ).ToString().Trim());
            int val = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colTIỀNĐÃĐÓNG).ToString().Trim());
            e.Cancel = gridView1.FocusedColumn.FieldName == "SỐ TIỀN ĐÓNG" && val == hocPhi;
        }

    }
}
