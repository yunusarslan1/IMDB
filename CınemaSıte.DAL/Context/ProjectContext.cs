using CınemaSıte.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CınemaSıte.DAL.Context
{
   public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=CınemaSıte;Integrated Security = True;";
            //Database.Connection.ConnectionString = @"Server=.;Database=yunus;uid=sa;pwd=123";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
