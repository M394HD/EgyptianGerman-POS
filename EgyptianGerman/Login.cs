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
using System.Xml.Linq;

namespace EgyptianGerman
{
    public partial class Login : Form
    {
        private string user;
        private int userCode;
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string Error = "برجاء التحقق من اسم المستخد و كلمة المرور";
            if (Check())
            {
                MainMenu mainMenu = new MainMenu(user,userCode);
                mainMenu.ShowDialog();
            }
            else
                MessageBox.Show(Error);

        }

        public bool Check()
        {
            var users=entities.Users.ToList();
            if(users!=null )
            {
                foreach( var item in users )
                {
                    if(item.username==textBoxusername.Text && item.password == textBoxPass.Text)
                    {
                        user = item.FullName;
                        userCode = item.userID;
                        return true;
                    }
                }
            }
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
