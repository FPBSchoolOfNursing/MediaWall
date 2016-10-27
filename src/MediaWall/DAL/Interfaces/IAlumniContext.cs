using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaWall.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaWall.DAL.Interfaces
{
    public interface IAlumniContext
    {
        DbSet<Alum> Alum { get; set; }
        DbSet<Class> Class { get; set; }
        DbSet<Pictures> Pictures { get; set; }
        int SaveChanges();
    }
}
