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
    public partial class ReportRefund : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();

        public ReportRefund()
        {
            InitializeComponent();
        }

        private void ReportRefund_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الرقم التعريفي", typeof(int));
            dt.Columns.Add("الإسم", typeof(string));
            dt.Columns.Add("الكمية", typeof(string));

            var allExpenses = entities.Products.Where(x => x.refundQntity != null).ToList();

            foreach (var ex in allExpenses)
            {
                dt.Rows.Add(ex.productID, ex.Name, ex.refundQntity);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
