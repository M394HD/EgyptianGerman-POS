using EgyptianGerman.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyptianGerman
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void PerformDateBasedAction()
        {
            EgyptianGermanEntities entities=new EgyptianGermanEntities();
            if(entities==null ) 
            {
                MessageBox.Show("Database Connection Error");
            }

            DateTime currentDate = DateTime.Now.Date;
            var products=entities.Products.ToList();

            if (products != null)
            {
                foreach( var product in products )
                {
                    if (currentDate != product.refundDate && product.refundDate!=null)
                    {
                        product.refundQntity = 0;
                    }
                }
                entities.SaveChanges();
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PerformDateBasedAction();
            Application.Run(new Login());
        }
    }
}
