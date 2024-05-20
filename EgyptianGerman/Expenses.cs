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
    public partial class Expenses : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();

        public Expenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("برجاء إدخال البيانات");
            }
            else
            {
                entities.Expenses.Add(new Expens
                {
                    Name = textBox1.Text,
                    Price = float.Parse(textBox2.Text),
                    Date = DateTime.Now
                });
                MessageBox.Show("تم إضافة مصروفات");
                entities.SaveChanges();
            }
        }
    }
}
