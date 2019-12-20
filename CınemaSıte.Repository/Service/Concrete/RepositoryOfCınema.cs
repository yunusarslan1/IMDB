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
    public class RepositoryOfCınema : BaseRepository, ICınemaRepository
    {
        Cinema cinema = new Cinema();

        public void Add(string tittle, string content, string pictureURL, int categoryID, int appUserID)
        {
            cinema.Title = tittle;
            cinema.Content = content;
            cinema.PictureUrl = pictureURL;
            cinema.CategoryID = categoryID;
            cinema.AppUserID = appUserID;
            db.Cinemas.Add(cinema);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            cinema = db.Cinemas.FirstOrDefault(x => x.ID == id);
            cinema.DeleteDate = DateTime.Now;
            cinema.Status = Status.Passive;
            db.SaveChanges();
        }

        public List<Cinema> FindByName(string title)
        {
            return db.Cinemas.Where(x => x.Title == title).ToList();
        }

        public List<Cinema> GetAll()
        {
            return db.Cinemas.ToList();
        }

        public List<Cinema> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.Cinemas.Where(x => x.AddDate >= startedDate && x.AddDate <= endDate).ToList();
        }

        public List<AppUser> TakeAppUserList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public List<Category> TakeCategoryList()
        {
            return db.Categories.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public List<Cinema> TakeList()
        {
            return db.Cinemas.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
        }

        public void TextBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void Update(int id, string tittle, string content, string pictureURL, int categoryID, int appUserID)
        {
            
                cinema = db.Cinemas.FirstOrDefault(x => x.ID == id);
                cinema.Title = tittle;
                cinema.Content = content;
                cinema.PictureUrl = pictureURL;
                cinema.CategoryID = categoryID;
                cinema.AppUserID = appUserID;
                cinema.Status = Status.Update;
                cinema.UpdateDate = DateTime.Now;
                db.SaveChanges();
            
        }
    }
}
