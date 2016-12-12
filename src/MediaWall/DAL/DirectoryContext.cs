using MediaWall.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace MediaWall.DAL
{
    public class DirectoryContext : DbContext, IDirectoryContext
    {
        public DirectoryContext(DbContextOptions<DirectoryContext> options) : base(options)
        {
        }        
    }
}
