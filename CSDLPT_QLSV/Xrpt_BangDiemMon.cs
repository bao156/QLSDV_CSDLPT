using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_QLSV
{
    public partial class Xrpt_BangDiemMon : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangDiemMon(String maLop, String maMon, int lan)
        {
            InitializeComponent();
            try
            {
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = maMon;
                this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
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
