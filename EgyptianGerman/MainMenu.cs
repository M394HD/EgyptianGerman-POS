using EgyptianGerman.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EgyptianGerman
{
    public partial class MainMenu : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        private string Name;
        private int userCode;
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(string name,int userID)
        {
            InitializeComponent();
            this.Name = name;
            this.userCode = userID;
            buttonReports.Visible = false;
            buttonMange.Visible = false;
            labeluserName.Text = Name;
            if (checkAdmin(userCode))
            {
                buttonMange.Visible = true;
                buttonReports.Visible = true;
            }
        }

        private bool checkAdmin(int id)
        {
            var currentUser = entities.Users.Where(x => x.userID == id).FirstOrDefault();
            if (currentUser != null)
            {
                if (currentUser.Role.Contains("Admin"))
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cashir cashir = new Cashir();
            cashir.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int SerialNo = 0;
            if (textBoxIn.Text.Contains("24"))
            {
                SerialNo= int.Parse(textBoxIn.Text);
            }
            var customerName = entities.Customers.Where(x => x.Name == textBoxIn.Text).FirstOrDefault();
            var serialNo = entities.Receipts.Where(x => x.SercialNo == SerialNo).FirstOrDefault();

            DataTable dt = new DataTable();
            dt.Columns.Add("الرقم المرجعي", typeof(string));
            dt.Columns.Add("تاريخ الإنشاء", typeof(string));
            dt.Columns.Add("طريقة الدفع", typeof(string));
            dt.Columns.Add("الإجمالي", typeof(string));

            if(customerName != null)
            {
                var Receipt = entities.Receipts.Where(x => x.customerID == customerName.customerID).ToList();
                foreach (var receipt in Receipt)
                    dt.Rows.Add(receipt.SercialNo, receipt.creatationDate, receipt.paymentMethod, receipt.Total);

            }
            else if(serialNo != null)
            {
                var receipt = entities.Receipts.Where(x => x.receiptID == serialNo.receiptID).FirstOrDefault();
                dt.Rows.Add(receipt.SercialNo, receipt.creatationDate, receipt.paymentMethod, receipt.Total);
            }

            dataGridView1.DataSource = dt;




        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Reporting r=new Reporting();
            r.ShowDialog();
        }

        private void buttonMange_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int receiptNo = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate TextBoxes with data from the selected row
                

                receiptNo=int.Parse((string)selectedRow.Cells["الرقم المرجعي"].Value);
            }

            NewFormReceipt n = new NewFormReceipt(receiptNo); n.ShowDialog();

            //ViewReceipt vr = entities.ViewReceipts.Where(x => x.SercialNo == receiptNo).FirstOrDefault();
        }
    }
}
