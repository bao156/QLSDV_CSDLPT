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
            lbMaGVLogin.Text = Program.username;
            lbHoTenLogin.Text = Program.mHoten;
            lbGroupLogin.Text = Program.mGroup;
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
    }
}
