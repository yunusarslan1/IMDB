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
    public partial class AdminCınemaPage : Form
    {
        public AdminCınemaPage()
        {
            InitializeComponent();
        }
        RepositoryOfCınema service = new RepositoryOfCınema();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service.Add(txtAddTitle.Text, txtAddContent.Text, fileName, (int)(cmbAddCategory.SelectedValue), (int)(cmbAddAuthor.SelectedValue));
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox1);
        }

        private void AdminCınemaPage_Load(object sender, EventArgs e)
        {
            cmbAddCategory.DataSource = service.TakeCategoryList();
            cmbAddCategory.DisplayMember = "Name";
            cmbAddCategory.ValueMember = "Id";
            cmbAddCategory.SelectedIndex = -1;

            cmbAddAuthor.DataSource = service.TakeAppUserList();
            cmbAddAuthor.DisplayMember = "FirstName";
            cmbAddAuthor.ValueMember = "Id";
            cmbAddAuthor.SelectedIndex = -1;

            dataGridView1.DataSource = service.TakeList();
        }

        string fileName;
        private void btnAddPictureUrl_Click(object sender, EventArgs e)
        {
            ofdAdd.Filter = "JPG | *jpg";
            if (ofdAdd.ShowDialog()== DialogResult.OK)
            {
                txtAddPictureUrl.Text = ofdAdd.FileName;
                fileName = ofdAdd.FileName;
            }

        }
    }
}
