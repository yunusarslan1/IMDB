﻿using CınemaSıte.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CınemaSıte.Repository.Service.Concrete
{
    public class BaseRepository
    {
        public ProjectContext db;

        public BaseRepository()
        {
            db = new ProjectContext();
        }
    }
}
