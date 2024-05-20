using DGVPrinterHelper;
using EgyptianGerman.helper;
using EgyptianGerman.Model;
using Microsoft.Identity.Client;
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
    public partial class Profit : Form
    {
        private EgyptianGermanEntities entities = new EgyptianGermanEntities();
        public Profit()
        {
            InitializeComponent();
            dataGridViewProfit.DefaultCellStyle.Font = new Font("Cairo", 15, GraphicsUnit.Pixel);
            dataGridViewProfit.RowTemplate.Height = 50;
            dataGridViewProfit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Profit_Load(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("الرقم المرجعي", typeof(string));
            dt.Columns.Add("تاريخ الإنشاء", typeof(string));
            dt.Columns.Add("إسم العميل", typeof(string));
            dt.Columns.Add("طريقة الدفع", typeof(string));
            dt.Columns.Add("الإجمالي", typeof(string));


            var Receipts = entities.Receipts.Where(x => x.creatationDate > dateTimePickerfrom.Value && x.creatationDate < dateTimePickerto.Value).ToList();
            double sum = 0;
            foreach (var item in Receipts)
            {
                var customerName = entities.Customers.Where(x => x.customerID == item.customerID).FirstOrDefault();
                dt.Rows.Add(item.SercialNo, item.creatationDate, customerName.Name, item.paymentMethod, item.Total);
                sum += item.Total;
            }

            dataGridViewProfit.DataSource = dt;
            labeltotal.Text = sum.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView profit = new DataGridView();
            double sum = 0;
            var allReceipts = entities.Receipts.Where(x => x.creatationDate > dateTimePickerfrom.Value && x.creatationDate < dateTimePickerto.Value).ToList();
            var allProducts = entities.Products.ToList();
            List<profitReport> profReport = new List<profitReport>();
            foreach (var item in allProducts)
            {
                profitReport tmp = new profitReport();
                tmp.Name = item.Name;
                tmp.idProduct = item.productID;
                tmp.Qnt = 0;
                tmp.Price = 0;
                profReport.Add(tmp);
            }

            foreach (var receipt in allReceipts)
            {
                var current = entities.Receipt_product.Where(x => x.ReceiptID == receipt.receiptID).ToList();
                foreach (var item in current)
                {
                    profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().Qnt += item.Quntity;
                    var priceCurrent = entities.Products.Where(x => x.productID == item.ProductID).FirstOrDefault().Price;
                    profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().Price += (item.Quntity * priceCurrent);
                }

            }

            DataTable dt = new DataTable();

            dt.Columns.Add("أسم المنتج", typeof(string));
            dt.Columns.Add("الكمية", typeof(string));
            dt.Columns.Add("السعر", typeof(string));


            foreach (var item in profReport)
            {
                if (item.Qnt != 0)
                {
                    dt.Rows.Add(item.Name, item.Qnt, item.Price);
                    sum += item.Price;
                }
            }

            DataRow dataRow = dt.NewRow();
            dataRow["السعر"] = sum;
            dt.Rows.Add(dataRow);
            dataGridViewProfit.DataSource = dt;


            int lastRow = dataGridViewProfit.RowCount - 1;


            labeltotal.Text = sum.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //dataGridViewProfit.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "تقرير ربحي\n\n";
            printer.SubTitle = string.Format("من {0} إلى {1} عن الفواتير", dateTimePickerfrom.Value.Date.ToString("dd/MM/yyyy"), dateTimePickerto.Value.Date.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.HeaderCellAlignment = StringAlignment.Center;
            // dataGridViewProfit.Height *=2;
            printer.TableAlignment = DGVPrinter.Alignment.Center;



            printer.PrintDataGridView(dataGridViewProfit);


        }

        private void dataGridViewProfit_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int lastRowIndex = dataGridViewProfit.Rows.Count - 1;

            if (e.RowIndex == lastRowIndex)
            {
                e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView profit = new DataGridView();
            double sum = 0;
            var allReceipts = entities.Receipts.Where(x => x.creatationDate > dateTimePickerfrom.Value && x.creatationDate < dateTimePickerto.Value).ToList();
            var allProducts = entities.Products.ToList();
            var allPurshases = entities.purchases.ToList();
            List<AllProfit> profReport = new List<AllProfit>();
            foreach (var item in allProducts)
            {
                AllProfit tmp = new AllProfit();
                for(int i = 0; i < allPurshases.Count; i++)
                {
                    if (item.Name == allPurshases[i].Name)
                    {
                        tmp.Name = item.Name;
                        tmp.idProduct = item.productID;
                        tmp.Qnt = 0;
                        tmp.Price = 0;
                        tmp.buyPrice = 0;
                        tmp.deff = 0;
                        profReport.Add(tmp);
                    }
                }
            }

            foreach (var receipt in allReceipts)
            {
                var current = entities.Receipt_product.Where(x => x.ReceiptID == receipt.receiptID).ToList();
                foreach (var item in current)
                {
                    profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().Qnt += item.Quntity;
                    var priceCurrent = entities.Products.Where(x => x.productID == item.ProductID).FirstOrDefault().Price;
                    profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().Price += (item.Quntity * priceCurrent);
                    
                    var buyCurrent=entities.purchases.Where(x=>x.ID==item.ProductID).FirstOrDefault().Price;
                    profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().buyPrice += (double)(item.Quntity * buyCurrent);
                    
                    profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().deff = profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().Price - profReport.Where(x => x.idProduct == item.ProductID).FirstOrDefault().buyPrice;
                }

            }

            DataTable dt = new DataTable();

            dt.Columns.Add("أسم المنتج", typeof(string));
            dt.Columns.Add("الكمية", typeof(string));
            dt.Columns.Add("سعر البيع", typeof(string));
            dt.Columns.Add("سعر الشراء", typeof(string));
            dt.Columns.Add("صافي ربح المنتج", typeof(string));


            foreach (var item in profReport)
            {
                if (item.Qnt != 0)
                {
                    dt.Rows.Add(item.Name, item.Qnt, item.Price,item.buyPrice,item.deff);
                    sum += item.deff;
                }
            }

            DataRow dataRow = dt.NewRow();
            dataRow["صافي ربح المنتج"] = sum;
            dt.Rows.Add(dataRow);
            dataGridViewProfit.DataSource = dt;


            int lastRow = dataGridViewProfit.RowCount - 1;


            labeltotal.Text = sum.ToString();
        }
    }
}
