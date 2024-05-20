using EgyptianGerman.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class NewFormReceipt : Form
    {
        public NewFormReceipt()
        {
            InitializeComponent();
            lastRecipt();
        }

        private void NewFormReceipt_Load(object sender, EventArgs e)
        {

            this.mainReport.RefreshReport();
        }

        private void mainReport_Load(object sender, EventArgs e)
        {
            
        }

        public void lastRecipt()
        {
            EgyptianGermanEntities entities = new EgyptianGermanEntities();

            List<ViewReceipt> vr = new List<ViewReceipt>();

            var q = from r in entities.Receipts
                    select r;

            var lastcheckAdded = entities.ViewReceipts.OrderByDescending(x => x.SercialNo).FirstOrDefault();

            var Q = entities.ViewReceipts.OrderByDescending(x => x.SercialNo).Select(x => x).Where(x => x.SercialNo == lastcheckAdded.SercialNo);
            

                var Products=entities.Products.ToList();
            foreach (var item in Q)
            {
                var currentProduct = Products.Where(x => x.productID == item.productID).FirstOrDefault();
                if (item.Discount == true)
                    item.Price=(double)(item.Price-currentProduct.maxDiscount);
                vr.Add(item);
            }
            if (vr != null)
            {
                mainReport.LocalReport.ReportEmbeddedResource = "EgyptianGerman.rprtReceipt.rdlc";
                mainReport.LocalReport.DataSources.Clear();
                mainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", vr));


                /*receipt.SetDataSource(vr);
                crystalReportViewer1.ReportSource = receipt;*/
            }
        }


        public NewFormReceipt(int id)
        {
            InitializeComponent();
            EgyptianGermanEntities entities = new EgyptianGermanEntities();

            List<ViewReceipt> vr = new List<ViewReceipt>();

            var q = from r in entities.Receipts
                    select r;


            var Q = entities.ViewReceipts.Select(x => x).Where(x => x.SercialNo == id);

            var Products = entities.Products.ToList();
            foreach (var item in Q)
            {
                var currentProduct = Products.Where(x => x.productID == item.productID).FirstOrDefault();
                if (item.Discount == true)
                    item.Price = (double)(item.Price - currentProduct.maxDiscount);
                vr.Add(item);
                
            }
            if (vr != null)
            {
                mainReport.LocalReport.ReportEmbeddedResource = "EgyptianGerman.rprtReceipt.rdlc";
                mainReport.LocalReport.DataSources.Clear();
                mainReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", vr));


                /*receipt.SetDataSource(vr);
                crystalReportViewer1.ReportSource = receipt;*/
            }
        }
    }
}
