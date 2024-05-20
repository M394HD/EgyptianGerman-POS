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
    public partial class ControlProducts : Form
    {
        private EgyptianGermanEntities entities = new EgyptianGermanEntities();
        public ControlProducts()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("رقم المنتج", typeof(int));
            dt.Columns.Add("الإسم", typeof(string));
            dt.Columns.Add("السعر", typeof(string));
            dt.Columns.Add("الخصم المسموح", typeof(string));
            dt.Columns.Add("الكمية", typeof(string));

            var allProducts = entities.Products.ToList();

            foreach (var prdct in allProducts)
            {
                dt.Rows.Add(prdct.productID, prdct.Name, prdct.Price, prdct.maxDiscount, prdct.quantity);
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
                textBoxID.Text = selectedRow.Cells["رقم المنتج"].Value.ToString();
                textBoxName.Text = selectedRow.Cells["الإسم"].Value.ToString();
                textBoxPrice.Text = selectedRow.Cells["السعر"].Value.ToString();
                textBoxMaxDiscount.Text = selectedRow.Cells["الخصم المسموح"].Value.ToString();
                textBoxQuntity.Text = selectedRow.Cells["الكمية"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("برجاء إختيار المنتج");
                return;
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                var current = entities.Products.Where(x => x.productID == id).FirstOrDefault();
                if (current != null)
                {
                    current.Name = textBoxName.Text;
                    current.Price = float.Parse(textBoxPrice.Text);
                    current.maxDiscount = float.Parse(textBoxMaxDiscount.Text);
                    current.quantity = int.Parse(textBoxQuntity.Text);
                    entities.SaveChanges();
                    MessageBox.Show("تم التعديل بنجاح");
                }
                else
                {
                    MessageBox.Show("برجاء إختيار المنتج");
                    return;
                }
            }
            LoadData();
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxMaxDiscount.Text = "";
            textBoxQuntity.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("برجاء إختيار المنتج");
                return;
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                var current = entities.Products.Where(x => x.productID == id).FirstOrDefault();
                if (current != null)
                {
                    entities.Products.Remove(current);
                    entities.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح");
                }
                else
                {
                    MessageBox.Show("برجاء إختيار المنتج");
                    return;
                }
            }
            
            LoadData();
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxMaxDiscount.Text = "";
            textBoxQuntity.Text = "";
        }
    }
}
