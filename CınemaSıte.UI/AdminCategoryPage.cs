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
    public partial class AdminCategoryPage : Form
    {
        public AdminCategoryPage()
        {
            InitializeComponent();
        }

        RepositoryOfCategory service = new RepositoryOfCategory();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service.Add(txtAddName.Text, txtAddDescription.Text);
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            service.Update(int.Parse(txtUpdateID.Text), txtUpdateName.Text, txtUpdateDesciption.Text);
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox3);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.Delete(int.Parse(txtDelete.Text));
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox4);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.FindByName(txtFindCategory.Text);
            service.TextBoxEraser(groupBox5);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void btnGetByDate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetByDateTime(DateTime.Parse(mskdStartDate.Text), DateTime.Parse(mskdEndDate.Text));
        }

        private void AdminCategoryPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.TakeList();
        }
    }
}
