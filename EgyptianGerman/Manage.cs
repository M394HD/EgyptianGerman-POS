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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelCustomers delCustomers = new DelCustomers();
            delCustomers.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ControlProducts controlProducts = new ControlProducts();
            controlProducts.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddUser addUser=new AddUser();
            addUser.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ControlPurshases controlPurshases = new ControlPurshases();
            controlPurshases.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ControlExpenses control=new ControlExpenses();
            control.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Refund refund = new Refund();
            refund.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
