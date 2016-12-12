using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaWall.DAL.Interfaces
{
    public interface IDirectoryContext
    {        
        int SaveChanges();
    }
}
