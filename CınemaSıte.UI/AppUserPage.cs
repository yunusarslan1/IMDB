using CınemaSıte.DAL.Context;
using CınemaSıte.Model.ORM.Entity.Abstract;
using CınemaSıte.Model.ORM.Entity.Concrete;
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
    public partial class AppUserPage : Form
    {
        public AppUserPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        int EklenenButonlar_Height = 0;
        int Soldan = 0, Ustten = 0;

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void AppUserPage_Load(object sender, EventArgs e)
        {
            List<Cinema> cinemas = db.Cinemas.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();

            foreach (var item in cinemas)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                GroupBox groupBox = new GroupBox();
                PictureBox pictureBox = new PictureBox();
                Label labeltitle = new Label();
                Label labelContent = new Label();

                flowLayoutPanel.Width = 200;
                flowLayoutPanel.Height = 500;
                flowLayoutPanel.Location = new Point(200, 80);

                groupBox.Size = new Size(1000, 1000);


                labeltitle.Text = item.Title;
                labeltitle.AutoSize = true;
                labeltitle.Width = flowLayoutPanel.Width;

                pictureBox.Height = 329;
                pictureBox.Image = new Bitmap(item.PictureUrl);
                pictureBox.Width = flowLayoutPanel.Width;

                labelContent.AutoSize = false;
                labelContent.Text = item.Content;
                labelContent.Height = 100;
                labelContent.Width = flowLayoutPanel.Width;

                flowLayoutPanel.Controls.Add(labeltitle);
                flowLayoutPanel.Controls.Add(pictureBox);
                flowLayoutPanel.Controls.Add(labelContent);
                this.Controls.Add(flowLayoutPanel);
                Ustten = (flowLayoutPanel.Height * (EklenenButonlar_Height / flowLayoutPanel.Height));

                EklenenButonlar_Height += flowLayoutPanel.Height;

                switch (EklenenButonlar_Height > this.Height)
                {
                    case true:
                        Ustten = 0;
                        Soldan += flowLayoutPanel.Width + 100;
                        EklenenButonlar_Height = flowLayoutPanel.Height;
                        break;
                }
                flowLayoutPanel.Location = new Point(Soldan + 0, Ustten + 20);
            }
        }
    }
    
}


