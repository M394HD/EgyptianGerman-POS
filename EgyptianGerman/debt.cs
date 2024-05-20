using EgyptianGerman.helper;
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
    public partial class debt : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        public debt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الإسم كامل", typeof(string));
            dt.Columns.Add("العنوان", typeof(string));
            dt.Columns.Add("نوع العميل", typeof(string));
            dt.Columns.Add("رقم الموبايل", typeof(string));
            dt.Columns.Add("الفلوس الي عليه", typeof(string));

            var customersWithDebt=entities.Customers.Where(x=>x.onDebt!=null && x.onDebt!=0).ToList();

            foreach (var customer in customersWithDebt)
            {
                dt.Rows.Add(customer.Name, customer.Address, customer.Type, customer.PhoneNo,  customer.onDebt);
            }

            dataGridView1.DataSource = dt;
        }

        private void buttononDebt_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الإسم كامل", typeof(string));
            dt.Columns.Add("العنوان", typeof(string));
            dt.Columns.Add("نوع العميل", typeof(string));
            dt.Columns.Add("رقم الموبايل", typeof(string));
            dt.Columns.Add("الفلوس الي عليا", typeof(string));

            var customersWithDebt = entities.Customers.Where(x => x.hasMoney != null && x.hasMoney != 0).ToList();

            foreach (var customer in customersWithDebt)
            {
                dt.Rows.Add(customer.Name, customer.Address, customer.Type, customer.PhoneNo,  customer.hasMoney);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
