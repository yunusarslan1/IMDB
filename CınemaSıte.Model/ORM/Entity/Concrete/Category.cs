﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CınemaSıte.Model.ORM.Entity.Concrete
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Cinema> Cinemas { get; set; }

    }
}
