using CınemaSıte.Model.ORM.Entity.Concrete;
using CınemaSıte.Repository.Service.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CınemaSıte.UI
{
    public partial class AdminUserPage : Form
    {
        public AdminUserPage()
        {
            InitializeComponent();
        }

        RepositoryofAppUser service = new RepositoryofAppUser();

        private void AdminUserPage_Load(object sender, EventArgs e)
        {
            service.GetEnum(cmbAddRole, cmbUpdateRole);
            dataGridView1.DataSource = service.TakeList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            service.Update(
                int.Parse(txtUpdateID.Text),
                txtUpdateFirstName.Text,
                txtUpdateLastName.Text,
                txtUpdateUserName.Text,
                txtUpdateEmail.Text,
                txtUpdatePassword.Text,
                (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text));
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service.Add(
               txtAddFirstName.Text,
               txtAddLastName.Text,
               txtAddUserName.Text,
               txtAddEmail.Text,
               txtAddPassword.Text,
               (Role)Enum.Parse(typeof(Role), cmbAddRole.Text));
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.Delete(int.Parse(txtDelete.Text));
            dataGridView1.DataSource = service.TakeList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.FindByName(txtFindCategory.Text);
            service.TextBoxEraser(groupBox5);
        }

        private void btnGetByDate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetByDateTime(DateTime.Parse(mskdStartDate.Text), DateTime.Parse(mskdEndDate.Text));
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }
        public void TextBoxCmbBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
