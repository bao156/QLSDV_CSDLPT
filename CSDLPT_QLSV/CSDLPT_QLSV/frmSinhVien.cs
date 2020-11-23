using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CSDLPT_QLSV
{
    public partial class frmSinhVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmSinhVien()
        {
            InitializeComponent();
            
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSV_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSV_DSPM.V_DS_PHANMANH);
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}