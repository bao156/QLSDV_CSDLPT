using System;
using System.Collections;
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
    public partial class frmMon : Form
    {
        static int viTri = 0;
        int currentIndex = 0;
        Stack undo = new Stack();
        DataTable dTable = new DataTable();
        DataRow rowUndo;
        public frmMon()
        {
            InitializeComponent();
            dTable.Columns.Add("MAMH", typeof(String));
            dTable.Columns.Add("TENMH", typeof(String));
            for (int i = 0; i < 2; i++)
            {
                gridView1.Columns[i].OptionsColumn.ReadOnly = true;
            }
          
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            bds.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLDSV_SERVER1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.bds.MONHOC);

            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.bds.DIEM);

            if (bds.MONHOC.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
            cbKhoa.SelectedIndex = Program.mChinhanh;
            Console.WriteLine(cbKhoa.SelectedIndex);

            if (undo.Count == 0)
            {
                btnUndo.Enabled = false;
            }
            btnHuyNhap.Enabled = false;
            btnLuu.Enabled = false;
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int viTri = bdsMonHoc.Position;
            gcMonHoc.Enabled = false;
            bdsMonHoc.AddNew();
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnUndo.Enabled = true;
            btnThoat.Enabled = false;
            btnHuyNhap.Enabled = true;
            cbKhoa.Enabled = false;
            txtMaMH.Focus();

            //Stack new Row
            undo.Push("Insert");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text.Trim();
            string tenMH = txtTenMH.Text.Trim();
            string signal = undo.Peek().ToString().Trim();
            if (maMH=="")
            {
                MessageBox.Show("Không được để trống mã môn học");
                return;
            }
            else if(tenMH=="")
            {
                MessageBox.Show("Không được để trống tên môn học");
                return;
            }
           if(signal.Equals("Insert"))
           {
                if (Program.KetNoi() == 0) return;
                String str = "dbo.SP_CHECKMAMH";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str;
                Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMH;
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Mã môn bị trùng");
                    return;
                }
            }
           

            try
            {
                this.bdsMonHoc.EndEdit();
                rowUndo = dTable.NewRow();
                rowUndo = ((DataRowView)this.bdsMonHoc[this.bdsMonHoc.Position]).Row;
                dTable.ImportRow(rowUndo);
                this.bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.bds.MONHOC);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
                dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                undo.Pop();
                return;
            }
            gcMonHoc.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            txtMaMH.Enabled = true;
            cbKhoa.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int viTri = bdsMonHoc.Position;
            gcMonHoc.Enabled = false;
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnUndo.Enabled = false;
            btnThoat.Enabled = false;
            btnHuyNhap.Enabled = true;
            txtMaMH.Enabled = false; ;
            cbKhoa.Enabled = false;
            //Stack new Row
            undo.Push("Edit");
            rowUndo = ((DataRowView)this.bdsMonHoc.Current).Row;
            dTable.ImportRow(rowUndo);
            Console.WriteLine(rowUndo["TENMH"].ToString());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            gcMonHoc.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            frmMon_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(undo.Count);
            String maMH;
            this.rowUndo = dTable.Rows[dTable.Rows.Count - 1];
            String pop = undo.Pop().ToString();
            Console.WriteLine(pop);

            if (pop == "Insert")
            {
                maMH = this.rowUndo["MAMH"].ToString();
                try
                {
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Update(this.bds.MONHOC);
                    dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học");
                    Console.WriteLine(ex);
                    this.mONHOCTableAdapter.Fill(this.bds.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                    undo.Push("Insert");
                }
            }
            else if (pop == "Delete")
            {
                DataRowView dr = (DataRowView)this.bdsMonHoc.AddNew();
                dr["MAMH"] = this.rowUndo["MAMH"].ToString();
                dr["TENMH"] = this.rowUndo["TENMH"].ToString();

                try
                {
                    this.bdsMonHoc.EndEdit();
                    this.bdsMonHoc.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.bds.MONHOC);
                    dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show(ex.Message);
                    undo.Push("Delete");
                }
            }
            else
            {
                DataRow temp = dTable.Rows[dTable.Rows.Count - 2];
                this.bdsMonHoc.Position = this.bdsMonHoc.Find("MAMH", this.rowUndo["MAMH"].ToString());
                Console.WriteLine(this.bdsMonHoc.Position);
                DataRowView dr = (DataRowView)this.bdsMonHoc.Current;
                dr["MAMH"] = temp["MAMH"].ToString();
                dr["TENMH"] = temp["TENMH"].ToString();

                try
                {
                    this.bdsMonHoc.EndEdit();
                    this.bdsMonHoc.ResetCurrentItem();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.bds.MONHOC);
                    dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                    dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show(ex.Message);
                    undo.Push("Edit");
                }
            }
            if (undo.Count == 0)
            {
                btnUndo.Enabled = false;
            }
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maMH = "";
            String message = "Bạn có chắc chắn muốn xóa?";
            String title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if(bdsDiem.Count>0)
                {
                    MessageBox.Show("KHÔNG THỂ XÓA MÔN NÀY!");
                }  
                else
                {
                    //Stack new Row
                    undo.Push("Delete");
                    try
                    {
                        maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                        rowUndo = dTable.NewRow();
                        rowUndo = ((DataRowView)this.bdsMonHoc.Current).Row;
                        dTable.ImportRow(rowUndo);
                        bdsMonHoc.RemoveCurrent();
                        this.mONHOCTableAdapter.Update(this.bds.MONHOC);
                        btnUndo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa môn học");
                        Console.WriteLine(ex);
                        this.mONHOCTableAdapter.Fill(this.bds.MONHOC);
                        bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                        undo.Pop();
                        return;
                    }
                }        
            }
            else
            {
                return;
            }

            if (bdsMonHoc.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedIndex == 2)
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
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.bds.MONHOC); //đổ dữ liệu từ SQL vào Dataset
                }
            }
        }

        private void btnHuyNhap_Click(object sender, EventArgs e)
        {
            String temp = undo.Pop().ToString();
            if (temp == "Insert")
            {
                this.bdsMonHoc.RemoveCurrent();
            }
            if (undo.Count == 0)
            {

                btnUndo.Enabled = false;
            }
            else
            {
                btnUndo.Enabled = true;
            }
            gcMonHoc.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            txtMaMH.Enabled = true;
            cbKhoa.Enabled = true;
        }
    }
}
