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
    public partial class AddCategory : Form
    {
        private EgyptianGermanEntities entities = new EgyptianGermanEntities();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string in_Category=textBoxCat.Text;
            if(in_Category != null)
            {
                entities.Categories.Add(new Category
                {
                    name = in_Category,
                });
                entities.SaveChanges();
                MessageBox.Show("تم إضافة تصنيف بنجاح");
            }
        }
    }    
}
