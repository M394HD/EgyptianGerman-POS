using EgyptianGerman.helper;
using EgyptianGerman.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EgyptianGerman
{
    public partial class Users : Form
    {
        private EgyptianGermanEntities entities=new EgyptianGermanEntities();
        
        public Users()
        {
            InitializeComponent();
            
            loadUsersData();

        }

        private void loadUsersData()
        {
            var users = entities.Users.ToList();
            List<UserModel> userModels = new List<UserModel>();
            for (int i = 0; i < users.Count; i++)
            {
                UserModel model = new UserModel();
                model.Id = users[i].userID;
                model.name = users[i].FullName;
                model.username = users[i].username;
                model.password = users[i].password;
                model.role = users[i].Role;
                userModels.Add(model);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("الإسم كامل", typeof(string));
            dt.Columns.Add("إسم المستخدم", typeof(string));
            dt.Columns.Add("كلمة المرور", typeof(string));
            dt.Columns.Add("النوع", typeof(string));

            foreach (var user in userModels)
            {
                dt.Rows.Add(user.name, user.username, user.password, user.role);
            }

            dataGridView1.DataSource = dt;
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();

                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate TextBoxes with data from the selected row
                textBoxfullName.Text = selectedRow.Cells["الإسم كامل"].Value.ToString();
                textBoxUserName.Text = selectedRow.Cells["إسم المستخدم"].Value.ToString();
                textBoxPassword.Text = selectedRow.Cells["كلمة المرور"].Value.ToString();
                textBoxRole.Text = selectedRow.Cells["النوع"].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = textBoxUserName.Text;
            user.password = textBoxPassword.Text;
            user.FullName=textBoxfullName.Text;
            user.Role=textBoxRole.Text;
            int counter = 0;
            var users=entities.Users.ToList();
            foreach (var u in users)
            {
                if (u.username == user.username)
                    counter++;
            }


            var Currentuser = entities.Users.Where(x => x.username == textBoxUserName.Text).FirstOrDefault();
            
            /*var Currentuser = entities.Users.Where(x => x.username == user.username).FirstOrDefault();*/
            if (Currentuser != null)
            {
                if (counter <= 1)
                {
                    Currentuser.username = user.username;
                    Currentuser.password = user.password;
                    Currentuser.FullName = user.FullName;
                    Currentuser.Role = user.Role;

                    entities.SaveChanges();
                    MessageBox.Show("تم تعديل المستخدم بنجاح");
                    loadUsersData();
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var CurrentUser=entities.Users.Where(x=>x.username == textBoxUserName.Text).FirstOrDefault();
            if (CurrentUser != null)
            {
                entities.Users.Remove(CurrentUser);
                entities.SaveChanges();
                MessageBox.Show("تم حذف العميل بنجاح");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
