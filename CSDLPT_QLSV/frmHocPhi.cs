using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_QLSV
{
    public partial class frmHocPhi : Form
    {
        int currentIndex = 0;
        Stack undo = new Stack();
        public frmHocPhi()
        {
            InitializeComponent();
            cbHocKy.SelectedIndex = 0;
            cbNienKhoa.SelectedIndex = 0;
            cbMaSV.SelectedIndex = -1;
            for (int i = 0; i < 4; i++)
            {
                gridView1.Columns[i].OptionsColumn.ReadOnly = true;
            }
        }

        private void hOCPHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHocPhi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_SERVER3);
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
           
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            qLDSV_SERVER3.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLDSV_SERVER3.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOCPHITableAdapter.Fill(this.qLDSV_SERVER3.HOCPHI);
            // TODO: This line of code loads data into the 'qLDSV_SERVER3.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_SERVER3.SINHVIEN);

            // TODO: This line of code loads data into the 'qLDSV_SERVER3.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONGHOCPHITableAdapter.Fill(this.qLDSV_SERVER3.CT_DONGHOCPHI);
            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int viTri = bdsHocPhi.Position;
            gcHocPhi.Enabled = false;
            bdsHocPhi.AddNew();
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = false;
            cbHocKy.SelectedIndex = 1;
            cbNienKhoa.SelectedIndex = 0;
            cbMaSV.SelectedIndex = 1;
            undo.Push("Insert");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String hocPhi = tbHocPhi.Text.Trim();
            String signal = undo.Peek().ToString().Trim();
            if (hocPhi == "")
            {
                MessageBox.Show("Học phí không được bỏ trống!!!!");
                return;
            }
            String maSV = cbMaSV.Text.Trim();
            String nienKhoa = cbNienKhoa.Text.Trim();
            String hocKy = cbHocKy.Text.Trim();
            bool check = true;
            if(signal.Equals("Insert"))
            {
                if (Program.KetNoi() == 0) return;
                String str = "dbo.SP_CHECKHOCPHI";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str;
                Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                Program.cmd.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienKhoa;
                Program.cmd.Parameters.Add("@HOCKY", SqlDbType.NChar).Value = hocKy;
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Đã nhập học phí kì " + hocKy + " niên khóa " + nienKhoa + "\n Vui lòng nhập lại!");
                    return;
                }
            }
            else if (signal.Equals("Edit"))
            {
                    if (Program.KetNoi() == 0) return;
                    String str = "dbo.SP_LAYTIENDADONG";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str;
                    Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                    Program.cmd.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienKhoa;
                    Program.cmd.Parameters.Add("@HOCKY", SqlDbType.NChar).Value = hocKy;
                    var returnParameter = Program.cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    Program.cmd.ExecuteNonQuery();
                    int result = int.Parse(returnParameter.Value.ToString());
                    int tienHP =int.Parse(hocPhi);
                    Console.WriteLine(result + "  " + tienHP);
                    if (tienHP <result) 
                    {
                        MessageBox.Show("VUI LÒNG ĐIỀU CHỈNH HỌC PHÍ KHÔNG DƯỚI "+result);
                        check = false;                 
                    }
            }
            if(check==true)
            {
                try
                {
                    this.bdsHocPhi.EndEdit();
                    this.bdsHocPhi.ResetCurrentItem();
                    this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hOCPHITableAdapter.Update(this.qLDSV_SERVER3.HOCPHI);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show(ex.Message);
                    return;
                }
            }    
          
            gcHocPhi.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int viTri = bdsHocPhi.Position;
            gcHocPhi.Enabled = false;
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = false;
            undo.Push("Edit");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.hOCPHITableAdapter.Fill(this.qLDSV_SERVER3.HOCPHI);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maSV = "";
            String message = "Bạn có chắc chắn muốn xóa?";
            String title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Stack new Row
                if (bdsChiTietHocPhi.Count > 0)
                {
                    MessageBox.Show("KHÔNG THỂ XÓA DO SINH VIÊN ĐÃ ĐÓNG TIỀN!");
                }
                else
                {
                    undo.Push("Delete");
                    try
                    {

                        bdsHocPhi.RemoveCurrent();
                        this.hOCPHITableAdapter.Update(this.qLDSV_SERVER3.HOCPHI);
                        btnUndo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên");
                        undo.Pop();
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
