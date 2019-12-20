using CınemaSıte.Model.ORM.Entity.Abstract;
using CınemaSıte.Model.ORM.Entity.Concrete;
using CınemaSıte.Repository.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CınemaSıte.Repository.Service.Concrete
{
    public class RepositoryOfCategory : BaseRepository, ICategoryRepository
    {
        Category category = new Category();

        public void Add(string name, string description)
        {
            category.Name = name;
            category.Description = description;
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.DeleteDate = DateTime.Now;
            category.Status = Status.Passive;
            db.SaveChanges();
        }

        public void TextBoxEraser(GroupBox groupBox1)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public List<Category> FindByName(string name)
        {
            return db.Categories.Where(x => x.Name == name).ToList();

        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.Categories.Where(x => x.AddDate >= startedDate && x.AddDate <= endDate).ToList();
        }

        public List<Category> TakeList()
        {
            return db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public void TexBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
            
        }

        public void Update(int id, string name, string description)
        {
            try
            {
                category = db.Categories.FirstOrDefault(x => x.ID == id);
                category.Name = name;
                category.Description = description;
                category.Status = Status.Update;
                category.UpdateDate = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter the ID of the category you want to update in the ID field..!");
            }
        }
    }
}
