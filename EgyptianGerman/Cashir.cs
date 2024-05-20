using EgyptianGerman.helper;
using EgyptianGerman.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyptianGerman
{
    public partial class Cashir : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        private List<purshasedItems> Listproducts = new List<purshasedItems>();
        private Product tmp = null;
        private int serialNo;
        private int qntity=1;
        private List<purshasedItems> itemReceipt = new List<purshasedItems>();

        public Cashir()
        {
            InitializeComponent();

            

        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Determine which button was clicked
            Button clickedButton = (Button)sender;

            /*DataTable dt=new DataTable();
            dt.Columns.Add("إسم المنتج", typeof(string));
            dt.Columns.Add("السعر", typeof(string));
            */
            
            var item =entities.Products.Where(x => x.Name==clickedButton.Name).FirstOrDefault();

            

            tmp = item;


            numericUpDown1.Visible = true;
            checkBoxdiscount.Visible= true;

            // Perform action based on the clicked button
            //MessageBox.Show($"Button '{clickedButton.Name}' clicked!");
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Cashir_Load(object sender, EventArgs e)
        {

            var data = entities.Customers.Select(item => item.Name).ToArray();

            // Create an AutoCompleteStringCollection
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(data);

            // Configure the TextBox for auto-complete
            textBoxName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxName.AutoCompleteCustomSource = autoCompleteData;


            button0.Click += num_Check;
            button1.Click += num_Check;
            button2.Click += num_Check;
            button3.Click += num_Check;
            button4.Click += num_Check;
            button5.Click += num_Check;
            button6.Click += num_Check;
            button7.Click += num_Check;
            button8.Click += num_Check;
            button9.Click += num_Check;
            buttonClear.Click += num_Check;

            //Categories

            var category = entities.Categories.ToList();
            foreach(var item in category)
            {
                comboBoxFilter.Items.Add(item.name);
            }


        }
        private void num_Check(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "CE")
            {
                textBoxNumIn.Text = "0";
            }
            else if (button.Text == ".")
            {
                if (!textBoxNumIn.Text.Contains("."))
                {
                    if (int.Parse(textBoxNumIn.Text) == 0)
                    {
                        button.Text = "0.";
                    }
                    else
                    {
                        textBoxNumIn.Text += button.Text;
                    }
                }
            }
            else
            {
                if (int.Parse(textBoxNumIn.Text) == 0)
                {
                    textBoxNumIn.Text = button.Text;
                }
                else
                {
                    textBoxNumIn.Text += button.Text;
                }
            }
        }

        private void LoadAllProducts(string category)
        {
            panel4.Controls.Clear();
            var catID=entities.Categories.Where(cat=>cat.name==comboBoxFilter.Text).Select(id=>id.categoryID).FirstOrDefault();
            var allproducts = entities.Products.Where(z=>z.categoryID==catID).ToList();
            if (allproducts.Count == 0)
            {
                
                Label label = new Label();
                label.Text = "لا يوجد منتجات";
                panel4.Controls.Add(label);
            }
            Button btnItem;
            int x = 10;
            int y = 0;
            int ylName = 100;
            int ylQnt = 120;
            int count = 1;
            for (int i = 0; i < allproducts.Count; i++)
            {
                Label lQnt=new Label();
                if (allproducts[i].quantity == 0)
                {
                    lQnt.Text = "غير متاح";
                    lQnt.ForeColor= Color.Red;
                }
                else
                {
                    lQnt.Text = "متاح "+allproducts[i].quantity.ToString();
                    lQnt.ForeColor= Color.Green;
                }
                lQnt.TextAlign = ContentAlignment.BottomCenter;
                lQnt.Location= new Point(x, ylQnt);

                Label lName=new Label();
                lName.Text = allproducts[i].Name;
                lName.Location= new Point(x, ylName);
                lName.TextAlign = ContentAlignment.BottomCenter;
                
                btnItem = new Button();
                btnItem.Name = allproducts[i].Name;

                btnItem.ForeColor= Color.White;
                btnItem.TextAlign = ContentAlignment.BottomCenter;
                btnItem.Size = new Size(100, 100);
                btnItem.Image = ByteArrayToImage(allproducts[i].Image);
                btnItem.Location = new Point(x, y);
                if (allproducts[i].quantity == 0)
                {
                    btnItem.Enabled = false;
                }
                panel4.Controls.Add(lName);
                panel4.Controls.Add(lQnt);
                panel4.Controls.Add(btnItem);
                x += 150;

                if (count == 3)
                {
                    y += 160;
                    ylName += 160;
                    ylQnt += 160;
                    x = 10;
                    count = 1;
                }
                else
                    count++;

                    

            }

            
        }


        private void btnClicked(string category,object sender,EventArgs e)
        {
            var catID=entities.Categories.Where(x=>x.name == category).Select(x=>x.categoryID).FirstOrDefault();
            var product = entities.Products.Where(x => x.categoryID == catID).ToList();

            Button btn=(Button)sender;

            MessageBox.Show(btn.Name);

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllProducts(comboBoxFilter.SelectedText);
            foreach (Control control in panel4.Controls)
            {
                // Check if the control is a button
                if (control is Button button)
                {
                    // Attach the same event handler to each button's Click event
                    button.Click += Button_Click;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            qntity=(int)numericUpDown1.Value;

            DataTable dt=new DataTable();
            dt.Columns.Add("إسم المنتج", typeof(string));
            dt.Columns.Add("الكمية", typeof(string));
            dt.Columns.Add("السعر", typeof(string));

            purshasedItems purshasedItems = new purshasedItems();

            if (tmp == null)
            {
                MessageBox.Show("برجاء اختيار منتج");
                return;
            }
            if (tmp.quantity < qntity)
            {
                MessageBox.Show("الكميه غير متوفره");
                return;
                
            }
            
            var currentProduct=entities.Products.Where(x=>x.productID==tmp.productID).FirstOrDefault();
            currentProduct.quantity -= qntity;
            

            purshasedItems.Name = tmp.Name;
            purshasedItems.Qntity = qntity;
            if (checkBoxdiscount.Checked)
            {
                var currentProduct_dis = entities.Products.Where(x => x.productID == tmp.productID).FirstOrDefault();
               
                purshasedItems.Price = (double)((tmp.Price * purshasedItems.Qntity) - currentProduct_dis.maxDiscount);

              // var item_rec= entities.Receipt_product.Where(x => x.ProductID == tmp.productID).FirstOrDefault();
                purshasedItems.Discount = true;
                entities.SaveChanges();
            }
            else
            {
                purshasedItems.Price = (double)tmp.Price*purshasedItems.Qntity;
            }
            itemReceipt.Add(purshasedItems);
            tmp = null;


            Listproducts.Add(purshasedItems);
            int sum = 0;
            foreach(var item in Listproducts)
            {
                
                dt.Rows.Add(item.Name, item.Qntity, item.Price);
                sum += (int)item.Price;
            }
            textBoxTotal.Text = sum.ToString();
            dataGridViewProducts.DataSource = dt;

            numericUpDown1.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = null;
            foreach(var item in Listproducts)
            {
                var current=entities.Products.Where(x=>x.Name==item.Name).FirstOrDefault();
                if(current != null)
                {
                    current.quantity += item.Qntity;
                }
            }
            Listproducts = new List<purshasedItems>();
            itemReceipt = new List<purshasedItems>();
            textBoxTotal.Text = string.Empty;
            checkBoxdiscount.Checked = false;
            checkBoxdiscount.Visible = false;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            
            if (Listproducts.Count == 0)
            {
                MessageBox.Show("برجاء وضع منتجات فالسلة");
                return;
            }
            else
            {
                if(textBoxName.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء إدخال عميل");
                    return;
                }
                var currentCustomer= entities.Customers.Where(x => x.Name == textBoxName.Text).FirstOrDefault();
                int Money = int.Parse(textBoxNumIn.Text);
                if (Money < int.Parse(textBoxTotal.Text) && comboBoxPayWith.Text != "قسط")
                {
                    MessageBox.Show("برجاء إدخال المبلغ صحيح");
                    return;
                }
                if (Money < int.Parse(textBoxTotal.Text) && comboBoxPayWith.Text == "قسط")
                {
                    int myMoney=int.Parse(textBoxTotal.Text)-Money;
                    currentCustomer.onDebt = myMoney;
                }
                DateTime today= DateTime.Now;
                string method = comboBoxPayWith.Text;
                var recipets=entities.Receipts.ToList();
            
                if(recipets.Count == 0)
                {
                    serialNo = 242001;
                }
                else
                {
                    serialNo = recipets[recipets.Count - 1].SercialNo + 1;
                }

               
                Receipt receipt =new Receipt();
                receipt.creatationDate= DateTime.Now;
                receipt.paymentMethod=method;
                receipt.SercialNo=serialNo;
                receipt.Total = int.Parse(textBoxTotal.Text);
                receipt.customerID = currentCustomer.customerID;
                foreach (var item in Listproducts)
                {
                    Receipt_product rectProduct = new Receipt_product();
                    var prodct=entities.Products.Where(x=>x.Name==item.Name).FirstOrDefault();
                    rectProduct.Product = prodct;
                    rectProduct.Quntity = item.Qntity;
                    rectProduct.Discount= item.Discount;
                    receipt.Receipt_product.Add(rectProduct);

                }

                entities.Receipts.Add(receipt);
            

                entities.SaveChanges();
                labelRest.Text=(float.Parse(textBoxNumIn.Text)-float.Parse(textBoxTotal.Text)).ToString();
                MessageBox.Show("تم الشراء بنجاح");

                Listproducts = null;
                itemReceipt = null;

                /*Check check = new Check();
                check.ShowDialog();*/

                NewFormReceipt n=new NewFormReceipt();
                n.ShowDialog();

                Listproducts = new List<purshasedItems>();
                itemReceipt = new List<purshasedItems>();
                textBoxTotal.Text = string.Empty;
                dataGridViewProducts.DataSource = null;
                panel4.Controls.Clear();
                comboBoxFilter.Text=string.Empty;
                comboBoxPayWith.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxNumIn.Text = "0";
                checkBoxdiscount.Checked = false;
                checkBoxdiscount.Visible = false;
            }

            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            var filteredData = entities.Customers
                                    .Where(item => item.Name.StartsWith(textBoxName.Text))
                                    .Select(item => item.Name)
                                    .ToArray();

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(filteredData);

            textBoxName.AutoCompleteCustomSource = autoCompleteData;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
