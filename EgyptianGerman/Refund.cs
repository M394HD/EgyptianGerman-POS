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
using System.Windows.Forms.VisualStyles;

namespace EgyptianGerman
{
    public partial class Refund : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        private List<purshasedItems> p = new List<purshasedItems>();
        private Dictionary<string,int> selectionproduct=new Dictionary<string,int>();


        private int selectedProduct = 0;

        public Refund()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            
            int serial = int.Parse(textBoxSerialNo.Text);
            var reciept=entities.Receipts.Where(x=>x.SercialNo==serial).FirstOrDefault();
            if (reciept!=null)
            {
                p.Clear();
                comboBoxProduct.Items.Clear();
                var product=reciept.Receipt_product.Select(x=>x).ToList();
                foreach(var item in product)
                {
                    
                    purshasedItems tmp = new purshasedItems();
                    var prdct = entities.Products.Where(x => x.productID == item.ProductID).FirstOrDefault();
                    tmp.Name = prdct.Name;
                    tmp.Price = prdct.Price;
                    tmp.Qntity = item.Quntity;
                    p.Add(tmp);
                    selectionproduct.Add(tmp.Name,item.ProductID);
                    comboBoxProduct.Items.Add(tmp.Name);
                    
                }
                
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp=p.Where(x=>x.Name==comboBoxProduct.Text).FirstOrDefault();

            textBoxPrice.Text = tmp.Price.ToString();
            textBoxQnt.Text = tmp.Qntity.ToString();

            selectedProduct = selectionproduct[tmp.Name];
            
        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {
            var currentProduct = entities.Products.Where(x=>x.productID==selectedProduct).FirstOrDefault();
            currentProduct.refundDate = DateTime.Now;
            currentProduct.refundQntity=int.Parse(textBoxQnt.Text);
            currentProduct.quantity += int.Parse(textBoxQnt.Text);
            entities.SaveChanges();
            MessageBox.Show("تم إرجاع المنتج بنجاح");
        }
    }
}
