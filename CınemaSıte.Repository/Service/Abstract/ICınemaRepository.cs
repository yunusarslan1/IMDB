using CınemaSıte.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CınemaSıte.Repository.Service.Abstract
{
    public interface ICınemaRepository
    {
        void Add(string tittle, string content, string pictureURL, int categoryID, int appUserID);
        void Update(int id, string tittle, string content, string pictureURL, int categoryID, int appUserID);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        List<Cinema> TakeList();
        List<Cinema> FindByName(string title);
        List<Cinema> GetAll();
        List<Cinema> GetByDateTime(DateTime startedDate, DateTime endDate);

        List<Category> TakeCategoryList();
        List<AppUser> TakeAppUserList();
    }
}
