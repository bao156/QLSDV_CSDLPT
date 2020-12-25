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
    public partial class frmSinhVien : Form
    {
        static int viTri = 0;
        int currentIndex = 0;
        Stack undo = new Stack();
        DataTable dTable=new DataTable();
        DataRow rowUndo;

        public frmSinhVien()
        {
            InitializeComponent();
            dTable.Columns.Add("MASV", typeof(String));
            dTable.Columns.Add("HO", typeof(String));
            dTable.Columns.Add("TEN", typeof(String));
            dTable.Columns.Add("MALOP", typeof(String));
            dTable.Columns.Add("PHAI", typeof(Boolean));
            dTable.Columns.Add("NGAYSINH", typeof(String));
            dTable.Columns.Add("NOISINH", typeof(String));
            dTable.Columns.Add("DIACHI", typeof(String));
            for (int i = 0; i < 10; i++)
            {
                gridView2.Columns[i].OptionsColumn.ReadOnly = true;
            }
              
        }
        private void sINHVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSinhVien1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.bds1);

        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);


            // TODO: This line of code loads data into the 'qLDSV_SiteMain.SINHVIEN' table. You can move, or remove it, as needed.

            currentIndex = Program.mChinhanh;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            bds.EnforceConstraints = false;
            bds1.EnforceConstraints = false;


            this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter1.Fill(this.bds1.SINHVIEN);

            // TODO: This line of code loads data into the 'qLDSV_SiteMain.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter1.Fill(this.bds1.LOP);

            // TODO: This line of code loads data into the 'bds1.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter1.Fill(this.bds1.DIEM);


            if (bds1.SINHVIEN.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            if (Program.mGroup != "PGV") cbKhoa.Enabled = false;
            cbKhoa.SelectedIndex = Program.mChinhanh;
            Console.WriteLine(cbKhoa.SelectedIndex);
            
            dateEditNS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditNS.Properties.DisplayFormat.FormatString = "dd' 'MMMM', 'yyyy";

            if (undo.Count == 0)
            {
                btnUndo.Enabled = false;
            }

            btnHuyNhap.Enabled = false;
            btnLuu.Enabled = false;
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text.Trim();
            String signal = undo.Peek().ToString().Trim();
            if (maSV == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống");
                return;
            }

            String ho = txtHo.Text.Trim();
            if (ho == "")
            {
                MessageBox.Show("Họ không được bỏ trống");
                return;
            }

            String ten = txtTen.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Tên không được bỏ trống");
                return;
            }

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
                    String str1 = "dbo.SP_CHECKMALOP";
                    Program.cmd = Program.conn.CreateCommand();
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    Program.cmd.CommandText = str1;
                    Program.cmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = maLop;
                    Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.cmd.ExecuteNonQuery();
                    int result1 = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                    if (result1 != 1)
                    {
                        MessageBox.Show("Lớp không tồn tại");
                        return;
                    }
                }
            }
            else
            {
                maLop = obMaLop.ToString().Trim();
            }

            Boolean phai;
            if (checkEditNam.Checked == false && checkEditNu.Checked == false)
            {
                MessageBox.Show("Phái không được bỏ trống");
                return;
            }
            else if (checkEditNam.Checked == true && checkEditNu.Checked == true)
            {
                MessageBox.Show("Chỉ được chọn 1 phái");
                return;
            }
            else if (checkEditNam.Checked == true && checkEditNu.Checked == false)
            {
                phai = true;
            }
            else phai = false;

            String ngaySinh = dateEditNS.EditValue.ToString();
            if (ngaySinh == "")
            {
                MessageBox.Show("Ngày sinh không được bỏ trống");
                return;
            }

            String noiSinh = txtNoiSinh.Text.Trim();
            if (noiSinh == "")
            {
                MessageBox.Show("Nơi sinh không được bỏ trống");
                return;
            }

            String diaChi = txtDiaChi.Text.Trim();
            if (diaChi == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống");
                return;
            }
            if(signal.Equals("Insert"))
            {
                if (Program.KetNoi() == 0) return;
                String str = "dbo.SP_CHECKMASV";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str;
                Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                int result = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Mã sinh viên bị trùng");

                    return;

                }
            }
            try
            {
                this.bdsSinhVien1.EndEdit();
                rowUndo = dTable.NewRow();
                rowUndo = ((DataRowView)this.bdsSinhVien1[this.bdsSinhVien1.Position]).Row;
                dTable.ImportRow(rowUndo);
                this.bdsSinhVien1.ResetCurrentItem();
                this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter1.Update(this.bds1.SINHVIEN);      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                undo.Pop();
                dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                return;
            }
            gcSV.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            txtMaSV.Enabled = true;
            cbKhoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int viTri = bdsSinhVien1.Position;
            gcSV.Enabled = false;
            bdsSinhVien1.AddNew();
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnUndo.Enabled = false;
            btnThoat.Enabled = false;
            checkEditNam.Checked = false;
            checkEditNu.Checked = false;
            cbMaLop.SelectedIndex = 1;
            btnHuyNhap.Enabled = true;
            txtMaSV.Focus();
            cbKhoa.Enabled = false;
            //Stack new Row
            undo.Push("Insert");
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int viTri = bdsSinhVien1.Position;
            gcSV.Enabled = false;
            btnThem.Enabled = false;
            btnEdit.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
            btnUndo.Enabled = false;
            btnThoat.Enabled = false;
            btnHuyNhap.Enabled = true;
            cbKhoa.Enabled = false;
            String phai = ((DataRowView)bdsSinhVien1[bdsSinhVien1.Position])["PHAI"].ToString();
            if (phai == "True")
            {
                checkEditNam.Checked = true;
                checkEditNu.Checked = false;
            }
            else
            {
                checkEditNam.Checked = false;
                checkEditNu.Checked = true;
            }
            txtMaSV.Enabled = false;

            //Stack new Row
            undo.Push("Edit");
            rowUndo = ((DataRowView)this.bdsSinhVien1.Current).Row;
            dTable.ImportRow(rowUndo);
            Console.WriteLine(rowUndo["TEN"].ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            gcSV.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnUndo.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            frmSinhVien_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maSV = ((DataRowView)bdsSinhVien1[bdsSinhVien1.Position])["MASV"].ToString();
            String message = "Bạn có chắc chắn muốn xóa?";
            String title = "Delete";
            MessageBoxButtons buttons=MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (Program.KetNoi() == 0) return;
                String str = "dbo.SP_CHECKSINHVIENDONGHP";
                Program.cmd = Program.conn.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = str;
                Program.cmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                Program.cmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                int result1 = int.Parse(Program.cmd.Parameters["@Ret"].Value.ToString());
                if (result1 == 1)
                {
                    MessageBox.Show("KHÔNG THỂ XÓA SINH VIÊN NÀY");
                    return;

                }
                //Stack new Row
                else if (bdsDiem1.Count>0)
                {
                    MessageBox.Show("KHÔNG THỂ XÓA SINH VIÊN NÀY!");
                }
                else
                {
                    undo.Push("Delete");
                    try
                    {
                        maSV = ((DataRowView)bdsSinhVien1[bdsSinhVien1.Position])["MASV"].ToString();
                        rowUndo = dTable.NewRow();
                        rowUndo = ((DataRowView)this.bdsSinhVien1.Current).Row;
                        dTable.ImportRow(rowUndo);
                        bdsSinhVien1.RemoveCurrent();
                        this.sINHVIENTableAdapter1.Update(this.bds1.SINHVIEN);
                        btnUndo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên");
                        Console.WriteLine(ex);
                        this.sINHVIENTableAdapter1.Fill(this.bds1.SINHVIEN);
                        bdsSinhVien1.Position = bdsSinhVien1.Find("MASV", maSV);
                        undo.Pop();
                        return;
                    }
                }    
            }
            else
            {
                return;
            }

            if (bdsSinhVien.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(undo.Count);
            String maSV;
            this.rowUndo = dTable.Rows[dTable.Rows.Count - 1];
            String pop = undo.Pop().ToString();
            Console.WriteLine(pop);

            if (pop.ToString() == "Insert")
            {
                maSV = this.rowUndo["MASV"].ToString();
                try
                {
                    bdsSinhVien1.Position = bdsSinhVien1.Find("MASV", maSV);
                    bdsSinhVien1.RemoveCurrent();
                    this.sINHVIENTableAdapter1.Update(this.bds1.SINHVIEN);
                    dTable.Rows.RemoveAt(dTable.Rows.Count - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên");
                    Console.WriteLine(ex);
                    this.sINHVIENTableAdapter1.Fill(this.bds1.SINHVIEN);
                    bdsSinhVien1.Position = bdsSinhVien1.Find("MASV", maSV);
                    undo.Push("Insert");
                }
            }
            else if (pop.ToString() == "Delete")
            {
                Console.WriteLine("Delete");
                DataRowView dr=(DataRowView)this.bdsSinhVien1.AddNew();
                dr["MASV"] = this.rowUndo["MASV"].ToString();
                dr["HO"] = this.rowUndo["HO"].ToString();
                dr["TEN"] = this.rowUndo["TEN"].ToString();
                dr["MALOP"] = this.rowUndo["MALOP"].ToString();
                dr["PHAI"] = this.rowUndo["PHAI"];
                dr["NGAYSINH"] = this.rowUndo["NGAYSINH"];
                dr["NOISINH"] = this.rowUndo["NOISINH"].ToString();
                dr["DIACHI"] = this.rowUndo["DIACHI"].ToString();
                try
                {
                    this.bdsSinhVien1.EndEdit();
                    this.bdsSinhVien1.ResetCurrentItem();
                    this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter1.Update(this.bds1.SINHVIEN);
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
                Console.WriteLine("Else");
                DataRow temp = dTable.Rows[dTable.Rows.Count - 2];
                this.bdsSinhVien1.Position = this.bdsSinhVien1.Find("MASV", this.rowUndo["MASV"].ToString());
                Console.WriteLine(this.bdsSinhVien1.Position);
                DataRowView dr =(DataRowView) this.bdsSinhVien1.Current;
                dr["MASV"] = temp["MASV"].ToString();
                dr["HO"] = temp["HO"].ToString();
                dr["TEN"] = temp["TEN"].ToString();
                dr["MALOP"] = temp["MALOP"].ToString();
                dr["PHAI"] = temp["PHAI"];
                dr["NGAYSINH"] = temp["NGAYSINH"];
                dr["NOISINH"] = temp["NOISINH"].ToString();
                dr["DIACHI"] = temp["DIACHI"].ToString();
                Console.WriteLine("what");
                Console.WriteLine(this.rowUndo["TEN"].ToString());
                Console.WriteLine(dr["TEN"]);
                try
                {
                    this.bdsSinhVien1.EndEdit();
                    this.bdsSinhVien1.ResetCurrentItem();
                    this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter1.Update(this.bds1.SINHVIEN);
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
                    bds1.EnforceConstraints = false;
                    this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter1.Fill(this.bds1.SINHVIEN); //đổ dữ liệu từ SQL vào Dataset
                    this.lOPTableAdapter1.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter1.Fill(this.bds1.LOP);
                }
            }
        }

        private void btnHuyNhap_Click(object sender, EventArgs e)
        {
            String temp=undo.Pop().ToString();
            if (temp == "Insert")
            {
                this.bdsSinhVien1.RemoveCurrent();
            }
            if (undo.Count == 0)
            {
                
                btnUndo.Enabled = false;
            }
            else
            {
                btnUndo.Enabled = true;
            }
            gcSV.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnReload.Enabled = true;
            btnThoat.Enabled = true;
            btnHuyNhap.Enabled = false;
            txtMaSV.Enabled = true;
            cbKhoa.Enabled = true;
        }

    }
}
