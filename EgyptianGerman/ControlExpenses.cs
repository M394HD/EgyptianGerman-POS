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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EgyptianGerman
{
    public partial class ControlExpenses : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        public ControlExpenses()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الرقم التعريفي", typeof(int));
            dt.Columns.Add("الإسم", typeof(string));
            dt.Columns.Add("السعر", typeof(string));
            dt.Columns.Add("التاريخ", typeof(string));

            var allExpenses=entities.Expenses.ToList();

            foreach (var ex in allExpenses)
            {
                dt.Rows.Add(ex.ID, ex.Name, ex.Price, ex.Date);
            }

            dataGridView1.DataSource = dt;
        }

        private void ControlExpenses_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate TextBoxes with data from the selected row
                textBoxID.Text = selectedRow.Cells["الرقم التعريفي"].Value.ToString();
                textBoxName.Text = selectedRow.Cells["الإسم"].Value.ToString();
                textBoxPrice.Text = selectedRow.Cells["السعر"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == string.Empty)
            {
                MessageBox.Show("برجاء إختيار مصروفات");
                return;
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                var current=entities.Expenses.Where(x=>x.ID==id).FirstOrDefault();
                if (current != null)
                {
                    current.Name = textBoxName.Text;
                    current.Price = float.Parse(textBoxPrice.Text);
                    current.Date = DateTime.Now;
                    entities.SaveChanges();
                    MessageBox.Show("تم التعديل بنجاح");
                }
                else
                {
                    MessageBox.Show("برجاء إختيار مصروفات");
                    return;
                }
            }
            LoadData();
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("برجاء إختيار مصروفات");
                return;
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                var current = entities.Expenses.Where(x => x.ID == id).FirstOrDefault();
                if (current != null)
                {
                    entities.Expenses.Remove(current);
                    entities.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح");
                }
                else
                {
                    MessageBox.Show("برجاء إختيار مصروفات");
                    return;
                }
            }
            LoadData();
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
        }
    }
}
