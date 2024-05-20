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
    public partial class DelCustomers : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();

        public DelCustomers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            loadCustomersData();
        }

        private void loadCustomersData()
        {
            var customers = entities.Customers.ToList();
            List<Customer> customer = new List<Customer>();
            for (int i = 0; i < customers.Count; i++)
            {
                Customer model = new Customer();
                model.customerID = customers[i].customerID;
                model.Name = customers[i].Name;
                model.Address = customers[i].Address;
                model.PhoneNo = customers[i].PhoneNo;
                model.onDebt = customers[i].onDebt;
                model.hasMoney = customers[i].hasMoney;
                customer.Add(model);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("الإسم كامل", typeof(string));
            dt.Columns.Add("العنوان", typeof(string));
            dt.Columns.Add("رقم الهاتف", typeof(string));
            dt.Columns.Add("مديون", typeof(string));
            dt.Columns.Add("ليه فلوس", typeof(string));
            
            foreach (var c in customer)
            {
                dt.Rows.Add(c.Name, c.Address, c.PhoneNo, c.onDebt, c.hasMoney);
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate TextBoxes with data from the selected row
                textBoxfullName.Text = selectedRow.Cells["الإسم كامل"].Value.ToString();
                textBoxAddress.Text = selectedRow.Cells["العنوان"].Value.ToString();
                textBoxPhoneNo.Text = selectedRow.Cells["رقم الهاتف"].Value.ToString();
                textBoxOnDebt.Text = selectedRow.Cells["مديون"].Value.ToString();
                textBoxHasMoney.Text = selectedRow.Cells["ليه فلوس"].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentCustomer=entities.Customers.Where(x=>x.Name==textBoxfullName.Text && x.PhoneNo==textBoxPhoneNo.Text).FirstOrDefault();
            entities.Customers.Remove(currentCustomer);
            entities.SaveChanges();
            MessageBox.Show("تم حذف العميل بنجاح");
            loadCustomersData();
        }
    }
}
