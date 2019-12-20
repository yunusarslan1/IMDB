using CınemaSıte.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CınemaSıte.Repository.Service.Abstract
{
   public interface ICategoryRepository
    {
        void Add(string name, string description);
        void Update (int id, string name, string description);
        void Delete(int id);
        void TexBoxEraser(GroupBox groupBox);
        List<Category> TakeList();
        List<Category> FindByName(string name);
        List<Category> GetAll();
        List<Category> GetByDateTime(DateTime startedDate, DateTime endDate);



    }
}
