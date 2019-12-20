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
    public class RepositoryofAppUser : BaseRepository, IAppUserRepository
    {
        AppUser user = new AppUser();

        public void Add(string firstName, string lastName, string userName, string email, string password, Role role)
        {
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = userName;
            user.Email = email;
            user.Password = password;
            user.Role = role;
            db.AppUsers.Add(user);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            user = db.AppUsers.FirstOrDefault(x => x.ID == id);
            user.DeleteDate = DateTime.Now;
            user.Status = Status.Passive;
            db.SaveChanges();
        }

        public List<AppUser> FindByName(string fullName)
        {
            return db.AppUsers.Where(x => x.FirstName  == fullName).ToList();
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public List<AppUser> GetByDateTime(DateTime startedDate, DateTime endDate)
        {
            return db.AppUsers.Where(x => x.AddDate >= startedDate && x.AddDate <= endDate).ToList();
        }

        public void GetEnum(ComboBox comboBoxAdd, ComboBox comboBoxUpdate)
        {
            comboBoxAdd.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxAdd.SelectedIndex = 0;

            comboBoxUpdate.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxUpdate.SelectedIndex = 0;
        }

        public List<AppUser> TakeList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
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

        public void Update(int id, string firstName, string lastName, string userName, string email, string password, Role role)
        {
            user = db.AppUsers.FirstOrDefault(x => x.ID == id);
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = userName;
            user.Email = email;
            user.Password = password;
            user.Role = role;
            user.Status = Status.Update;
            user.UpdateDate = DateTime.Now;
            db.SaveChanges();

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
