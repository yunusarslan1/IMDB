﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CınemaSıte.Model.ORM.Entity.Concrete
{
    public enum Role
    {
        None=0,
        Admin=1,
        Member=2,
        Employee=3,
        Author=4
    }
    public class AppUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public virtual List<Cinema> Cinemas { get; set; }

    }
}
