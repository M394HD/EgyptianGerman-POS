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
    public partial class AddCustomer : Form
    {
        private EgyptianGermanEntities entities = new EgyptianGermanEntities();

        public AddCustomer()
        {
            InitializeComponent();
        }

        

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            string in_customerName=textBoxCustomerName.Text;
            string in_customerPhone=textBoxPhoneNumber.Text;
            string in_customerAddress=textBoxAddress.Text;
            double in_customerOnDebt = double.Parse(textBoxDebt.Text);
            double in_customerHasMoney = double.Parse(textBoxCheck.Text);
            if(in_customerPhone.Length!=11)
            {
                MessageBox.Show("رقم الموبايل غير صحيح");
            }
            else
            {
                entities.Customers.Add(new Customer
                {
                    Name = in_customerName,
                    Address = in_customerAddress,
                    PhoneNo = in_customerPhone,
                    onDebt = in_customerOnDebt,
                    hasMoney = in_customerHasMoney,
                    Type = comboBox1.SelectedText
                });

                MessageBox.Show("تم إضافة عميل بنجاح");
                entities.SaveChanges();
            }

        }
    }
}
