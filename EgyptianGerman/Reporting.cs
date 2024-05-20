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
    public partial class Reporting : Form
    {
        public Reporting()
        {
            InitializeComponent();
        }

        private void buttonDebt_Click(object sender, EventArgs e)
        {
            debt d=new debt();
            d.ShowDialog();

        }

        private void buttonProfit_Click(object sender, EventArgs e)
        {
            Profit p = new Profit();
            p.ShowDialog();
        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {
            ReportRefund r=new ReportRefund();
            r.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
