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
    public partial class ControlPurshases : Form
    {

        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        private Dictionary<string,int> pairs = new Dictionary<string,int>();
        public ControlPurshases()
        {
            InitializeComponent();
        }

        private void ControlPurshases_Load(object sender, EventArgs e)
        {
            var products=entities.purchases.ToList();
            foreach(var product in products)
            {
                comboBoxproducts.Items.Add(product.Name);
                pairs.Add(product.Name, product.ID);
            }
            
        }

        private void comboBoxproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = pairs[comboBoxproducts.Text];
            
            var current=entities.purchases.Where(x=>x.ID==id).FirstOrDefault();

            textBoxID.Text=current.ID.ToString();
            textBoxName.Text=current.Name.ToString();
            textBoxPrice.Text=current.Price.ToString();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("برجاء إختيار منتج");
                return;
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                var current = entities.purchases.Where(x => x.ID == id).FirstOrDefault();
                current.Name= textBoxName.Text;
                current.Price=float.Parse(textBoxPrice.Text);
                current.Date=DateTime.Now;
                entities.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("برجاء إختيار منتج");
                return;
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                var current = entities.purchases.Where(x => x.ID == id).FirstOrDefault();
                entities.purchases.Remove(current);
                entities.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }
    }
}
