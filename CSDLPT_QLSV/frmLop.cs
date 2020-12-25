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
    public partial class frmLop : Form
    {
        static int viTri = 0;
        int currentIndex = 0;
        Stack undo = new Stack();
        DataTable dTable = new DataTable();
        DataRow rowUndo;
        public frmLop()
        {
            InitializeComponent();
            dTable.Columns.Add("MALOP", typeof(String));
            dTable.Columns.Add("TENLOP", typeof(String));
            dTable.Columns.Add("MAKH", typeof(String));
            for (int i = 0; i < 3; i++)
            {
                gridView1.Columns[i].OptionsColumn.ReadOnly = true;
            }
            
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            bds.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.bds.LOP);

            // TODO: This line of code loads data into the 'bds.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.bds.SINHVIEN);
       

            if (bds.LOP.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
            txtMaKhoa.Enabled = false;
            cbKhoa.SelectedIndex = Program.mChinhanh;

            if (undo.Count == 0)
            {
                btnUndo.Enabled = false;
            }
            btnHuyNhap.Enabled = false;
            btnLuu.Enabled = false;
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int viTri = bdsLop.Position;
            gcLop.Enabled = false;
            bdsLop.AddNew();
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnUndo.Enabled = false;
            btnThoat.Enabled = false;
            btnHuyNhap.Enabled = true;
            txtMaLop.Focus();
            cbKhoa.Enabled = false;
            MessageBox.Show(Program.mChinhanh.ToString());
            if (cbKhoa.Text.Equals("CNTT-Công Nghê Thông Tin"))
            {
                txtMaKhoa.Text = "CNTT";
            }
            else
            {
                txtMaKhoa.Text = "VT";
            }

            //Stack new Row
            undo.Push("Insert");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int viTri = bdsLop.Position;
            gcLop.Enabled = false;
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnUndo.Enabled = false;
            btnThoat.Enabled = false;
            btnHuyNhap.Enabled = true;
            txtMaLop.Enabled = false;
            cbKhoa.Enabled = false;

            //Stack new Row
            undo.Push("Edit");
            rowUndo = ((DataRowView)this.bdsLop.Current).Row;
            dTable.ImportRow(rowUndo);
            Console.WriteLine(rowUndo["TENLOP"].ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string maKH = "";
            string signal = undo.Peek().ToString().Trim();
            if (cbKhoa.SelectedIndex == 0)
            {
                maKH = "CNTT";
            }
            else
            {
                maKH = "VT";
            }
            
            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống");
                return;
            }
            if (tenLop == "")
            {
                MessageBox.Show("Tên lớp không được để trống");
                return;
            }

            if(signal.Equals("Insert"))
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
                if (result == 1)
                {
                    MessageBox.Show("Mã lớp bị trùng");
                    return;
                }
            }    
            try
            {
                this.bdsLop.EndEdit();
                rowUndo = dTable.NewRow();
                rowUndo = ((DataRowView)this.bdsLop[this.bdsLop.Position]).Row;
                dTable.ImportRow(rowUndo);
                this.bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.bds.LOP);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Lỗi khi thêm lớp");
                dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                undo.Pop();
                return;
            }
            gcLop.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            cbKhoa.Enabled = true;
            txtMaLop.Enabled = true;
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

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(undo.Count);
            String maLop;
            this.rowUndo = dTable.Rows[dTable.Rows.Count - 1];
            String pop = undo.Pop().ToString();

            if (pop == "Insert")
            {
                maLop = this.rowUndo["MALOP"].ToString();
                try
                {
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.bds.LOP);
                    dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp");
                    Console.WriteLine(ex);
                    this.lOPTableAdapter.Fill(this.bds.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    undo.Push("Insert");
                }
            }
            else if (pop == "Delete")
            {
                Console.WriteLine("Delete");
                DataRowView dr = (DataRowView)this.bdsLop.AddNew();
                dr["MALOP"] = this.rowUndo["MALOP"].ToString();
                dr["TENLOP"] = this.rowUndo["TENLOP"].ToString();
                dr["MAKH"] = this.rowUndo["MAKH"].ToString();

                try
                {
                    this.bdsLop.EndEdit();
                    this.bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.bds.LOP);
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
                this.bdsLop.Position = this.bdsLop.Find("MALOP", this.rowUndo["MALOP"].ToString());
                Console.WriteLine(this.bdsLop.Position);
                DataRowView dr = (DataRowView)this.bdsLop.Current;
                dr["MALOP"] = temp["MALOP"].ToString();
                dr["TENLOP"] = temp["TENLOP"].ToString();
                dr["MAKH"] = temp["MAKH"].ToString();

                try
                {
                    this.bdsLop.EndEdit();
                    this.bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.bds.LOP);
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            gcLop.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            frmLop_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maLop = "";
            String message = "Bạn có chắc chắn muốn xóa?";
            String title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Stack new Row
                if(bdsSinhVien.Count>0)
                {
                    MessageBox.Show("KHÔNG THỂ XÓA LỚP NÀY!");
                }    
                else
                {
                    undo.Push("Delete");
                    try
                    {
                        maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                        rowUndo = dTable.NewRow();
                        rowUndo = ((DataRowView)this.bdsLop.Current).Row;
                        dTable.ImportRow(rowUndo);
                        bdsLop.RemoveCurrent();
                        this.lOPTableAdapter.Update(this.bds.LOP);
                        btnUndo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa lớp");
                        Console.WriteLine(ex);
                        this.lOPTableAdapter.Fill(this.bds.LOP);
                        bdsLop.Position = bdsLop.Find("MALOP", maLop);
                        undo.Pop();
                        return;
                    }
                }    
                
            }
            else
            {
                return;
            }

            if (bdsLop.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnHuyNhap_Click(object sender, EventArgs e)
        {
            String temp = undo.Pop().ToString();
            if (temp == "Insert")
            {
                this.bdsLop.RemoveCurrent();
            }
            if (undo.Count == 0)
            {

                btnUndo.Enabled = false;
            }
            else
            {
                btnUndo.Enabled = true;
            }
            gcLop.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            txtMaLop.Enabled = true;
            cbKhoa.Enabled = true;
        }
    }
}
