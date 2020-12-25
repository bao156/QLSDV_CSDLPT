using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSDLPT_QLSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = "FORM MAIN";
            lbMaGVLogin.Text = Program.username;
            lbHoTenLogin.Text = Program.mHoten;
            lbGroupLogin.Text = Program.mGroup;
            if (Program.mGroup == "User")
            {
                bBtnTaoTK.Enabled = false;
                bBtnDiemTongKet.Enabled = false;
                bBtnDiemThi.Enabled = false;
                bBtnDSLop.Enabled = false;
                bBtnPhieuDiem.Enabled = false;
                bBtnGrade.Enabled = false;
                bBtnDiemMH.Enabled = false;
                bBtnFee.Enabled = false;
                bBtnHPLop.Enabled = false;
                btnDongHocPhi.Enabled = false;
            }
            if (Program.mGroup != "PKeToan")
            {
                bBtnFee.Enabled = false;
                bBtnHPLop.Enabled = false;
                btnDongHocPhi.Enabled = false;
        

            }
            else
            {
                bBtnClass.Enabled = false;
                bBtnGrade.Enabled = false;
                bBtnSubject.Enabled = false;
                bBtnGrade.Enabled = false;
                bBtnDiemTongKet.Enabled = false;
                bBtnDiemThi.Enabled = false;
                bBtnDSLop.Enabled = false;
                bBtnPhieuDiem.Enabled = false;
                bBtnGrade.Enabled = false;
                bBtnDiemMH.Enabled = false;
            }


            if(!Program.mChinhanh.ToString().Trim().Equals("2"))
            {
                Form frm = this.CheckExists(typeof(frmSinhVien));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmSinhVien frmSinhVien = new frmSinhVien();
                    frmSinhVien.MdiParent = this;
                    frmSinhVien.Show();
                }
            }
            else
            {
                Form frm = this.CheckExists(typeof(frmDongHocPhi));
                if (frm != null)
                {
                    frm.Activate();
                }
                else
                {
                    frmDongHocPhi frmDongHocPhi = new frmDongHocPhi();
                    frmDongHocPhi.MdiParent = this;
                    frmDongHocPhi.Show();
                }
            }    
           
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void bBtnStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSinhVien frmSinhVien = new frmSinhVien();
                frmSinhVien.MdiParent = this;
                frmSinhVien.Show();
            }
        }

        private void bBtnSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form frm = this.CheckExists(typeof(frmMon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMon frmMon = new frmMon();
                frmMon.MdiParent = this;
                frmMon.Show();
            }
        }

        private void bBtnClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLop frmLop = new frmLop();
                frmLop.MdiParent = this;
                frmLop.Show();
            }
        }

        private void bBtnGrade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDiem frmDiem = new frmDiem();
                frmDiem.MdiParent = this;
                frmDiem.Show();
            }
        }

        private void bBtnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            Form frm = this.CheckExists(typeof(frmTaoLogin));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTaoLogin frmTaoLogin = new frmTaoLogin();
                frmTaoLogin.MdiParent = this;
                frmTaoLogin.Show();
            }
        }

        private void bBtnFee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmHocPhi frmHocPhi = new frmHocPhi();
                frmHocPhi.MdiParent = this;
                frmHocPhi.Show();
            }
        }

        private void bBtnDSLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
      
            Form frm = this.CheckExists(typeof(fRpt_DanhSachSinhVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fRpt_DanhSachSinhVien fRpt_DanhSachSinhVien = new fRpt_DanhSachSinhVien();
                fRpt_DanhSachSinhVien.MdiParent = this;
                fRpt_DanhSachSinhVien.Show();
            }
        }

        private void bBtnDiemThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            Form frm = this.CheckExists(typeof(fRpt_BangDiemThiHetMon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fRpt_BangDiemThiHetMon fRpt_BangDiemThiHetMon = new fRpt_BangDiemThiHetMon();
                fRpt_BangDiemThiHetMon.MdiParent = this;
                fRpt_BangDiemThiHetMon.Show();
            }
        }

        private void bBtnDiemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            Form frm = this.CheckExists(typeof(fRpt_BangDiemMon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fRpt_BangDiemMon fRpt_BangDiemMon = new fRpt_BangDiemMon();
                fRpt_BangDiemMon.MdiParent = this;
                fRpt_BangDiemMon.Show();
            }
        }

        private void bBtnPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
 
            Form frm = this.CheckExists(typeof(fRpt_PhieuDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fRpt_PhieuDiem fRpt_PhieuDiem = new fRpt_PhieuDiem();
                fRpt_PhieuDiem.MdiParent = this;
                fRpt_PhieuDiem.Show();
            }
        }

        private void bBtnHPLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
   
            Form frm = this.CheckExists(typeof(fRpt_HocPhiLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fRpt_HocPhiLop fRpt_HocPhiLop = new fRpt_HocPhiLop();
                fRpt_HocPhiLop.MdiParent = this;
                fRpt_HocPhiLop.Show();
            }
        }

        private void bBtnDiemTongKet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = this.CheckExists(typeof(fRpt_BangDiemTongKet));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fRpt_BangDiemTongKet fRpt_BangDiemTongKet = new fRpt_BangDiemTongKet();
                fRpt_BangDiemTongKet.MdiParent = this;
                fRpt_BangDiemTongKet.Show();
            }
        }

        private void bBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.servername = "";
            Program.username = "";
            Program.mlogin = "";
            Program.password = "";
            Program.mloginDN = "";
            Program.passwordDN = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.mChinhanh = 0;
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.Show();
            }
        }

        private void btnDongHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form frm = this.CheckExists(typeof(frmDongHocPhi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDongHocPhi frmDongHocPhi = new frmDongHocPhi();
                frmDongHocPhi.MdiParent = this;
                frmDongHocPhi.Show();
            }
        }
    }
}
