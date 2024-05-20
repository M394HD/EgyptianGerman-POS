using EgyptianGerman.helper;
using EgyptianGerman.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyptianGerman
{
    public partial class AddProduct : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var allCategories=entities.Categories.ToList();
            foreach (var item in allCategories)
            {
                comboBoxCategory.Items.Add(item.name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            PictureBox pictureBox = pictureBox1 as PictureBox;
            if(pictureBox != null )
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image=new Bitmap(openFileDialog.FileName);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            byte[] image=stream.GetBuffer();
            //MessageBox.Show(image[0].ToString());
            string nameOfCat=comboBoxCategory.Text;
            
            Product product = new Product();
            product.Name = textBoxName.Text;
            product.Image = stream.GetBuffer();
            product.Price = double.Parse(textBoxPrice.Text);
            product.maxDiscount = double.Parse(textBoxDiscount.Text);
            product.description = textBoxDescription.Text;
            product.categoryID = entities.Categories.Where(x => x.name == nameOfCat).Select(x => x.categoryID).FirstOrDefault();
            product.quantity = int.Parse(textBoxInventory.Text);
            entities.Products.Add(product);
            
            purchase purchase = new purchase();
            purchase.Name = textBoxName.Text;
            purchase.Price = double.Parse(textBoxpushase.Text);
            purchase.Date = DateTime.Now;
            entities.purchases.Add(purchase);



            
            entities.SaveChanges();
            MessageBox.Show("تم إضافة منتج بنجاح");


        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
