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
    public partial class UpdateCustomer : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            var customers=entities.Customers.ToList();
            foreach (var customer in customers)
            {
                comboBoxCustomer.Items.Add(customer.Name);
            }
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentCustomer = entities.Customers.Where(x => x.Name == comboBoxCustomer.SelectedItem).FirstOrDefault();
            if (currentCustomer != null)
            {
                textBoxName.Text = currentCustomer.Name;
                textBoxPhone.Text = currentCustomer.PhoneNo;
                textBoxAddress.Text = currentCustomer.Address;
                textBoxOnDebt.Text = currentCustomer.onDebt.ToString();
                textBoxHasMoney.Text = currentCustomer.hasMoney.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentCustomer = entities.Customers.Where(x => x.Name == comboBoxCustomer.SelectedItem).FirstOrDefault();
            if (currentCustomer != null)
            {
                currentCustomer.Name = textBoxName.Text;
                currentCustomer.PhoneNo = textBoxPhone.Text;
                currentCustomer.Address = textBoxAddress.Text;
                currentCustomer.onDebt = double.Parse(textBoxOnDebt.Text);
                currentCustomer.hasMoney = double.Parse(textBoxHasMoney.Text);
                entities.SaveChanges();
                MessageBox.Show("تم تعديل البيانات بنجاح");
            }
            else
                MessageBox.Show("برجاء إختيار عميل");
        }
    }
}
