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
    public partial class AddUser : Form
    {
        private EgyptianGermanEntities dbContext=new EgyptianGermanEntities();
        public AddUser()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string in_username=textBoxUsername.Text;
            string in_password=textBoxPassword.Text;
            string in_fullname=textBoxFullName.Text;
            string in_role = "User";

            bool found = false;
            var users = dbContext.Users.ToList();
            
            if (in_username != null && in_fullname != null && in_password != null)
            {
                if (in_password.Length < 8)
                {
                    MessageBox.Show("كلمة المرور يجب ان تكون 8 حروف او ارقام على الاقل");
                }
                else
                {
                    if (users.Count == 0)
                    {
                        dbContext.Users.Add(new User
                        {
                            username = in_username,
                            password = in_password,
                            FullName = in_fullname,
                            Role = in_role
                        });

                        dbContext.SaveChanges();
                        MessageBox.Show("تم اضافة مستخدم بنجاح");
                    }
                    foreach (var item in users)
                    {
                        if (item.username == in_username)
                        {
                            found = true;
                            MessageBox.Show("إسم المستخدم موجود بالفعل حاول بإسم مستخدم جديد");
                            break;
                        }
                        else
                        {
                            dbContext.Users.Add(new User
                            {
                                username = in_username,
                                password = in_password,
                                FullName = in_fullname,
                                Role = in_role
                            });

                            dbContext.SaveChanges();
                            MessageBox.Show("تم اضافة مستخدم بنجاح");

                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("الرجاء ملء جميع البيانات");
            }



            


            
        }
    }
}
