using EgyptianGerman.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyptianGerman
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            EgyptianGermanEntities entities=new EgyptianGermanEntities();
            CrystalReportReceipt receipt = new CrystalReportReceipt();
            List<ViewReceipt> vr = new List<ViewReceipt>();

            var q = from r in entities.Receipts
                    select r;

            var lastcheckAdded = entities.ViewReceipts.OrderByDescending(x => x.SercialNo).FirstOrDefault();

            var Q = entities.ViewReceipts.OrderByDescending(x => x.SercialNo).Select(x => x).Where(x => x.SercialNo == lastcheckAdded.SercialNo);

            foreach(var item in Q)
            {
                vr.Add(item);
            }
            if (vr != null)
            {
                receipt.SetDataSource(vr);
                crystalReportViewer1.ReportSource = receipt;
            }
        }

        private void Check_Load(object sender, EventArgs e)
        {

        }
    }
}
