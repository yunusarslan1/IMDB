using CınemaSıte.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CınemaSıte.Repository.Service.Abstract
{
    public interface IAppUserRepository
    {
        void Add(string firstName, string lastName, string userName, string email, string password, Role role);
        void Update(int id, string firstName, string lastName, string userName, string email, string password, Role role);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        void GetEnum(ComboBox comboBoxAdd, ComboBox comboBoxUpdate);
        List<AppUser> TakeList();
        List<AppUser> FindByName(string fullName);
        List<AppUser> GetAll();
        List<AppUser> GetByDateTime(DateTime startedDate, DateTime endDate);
       
    }
}
