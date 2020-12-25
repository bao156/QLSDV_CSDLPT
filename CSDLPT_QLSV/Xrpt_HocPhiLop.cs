using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT_QLSV
{
    public partial class Xrpt_HocPhiLop : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_HocPhiLop(String maLop, String nienKhoa, int hocKy)
        {
            InitializeComponent();
            try
            {
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = nienKhoa;
                this.sqlDataSource1.Queries[0].Parameters[2].Value = hocKy;
                this.sqlDataSource1.Fill();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                this.StopPageBuilding();
                Print(e.InnerException.Message);
            }

        }

    }
}
