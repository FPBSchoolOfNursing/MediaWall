using MediaWall.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using MediaWall.Models;

namespace MediaWall.DAL
{
    public class DirectoryContext : DbContext, IDirectoryContext
    {
        public DirectoryContext(DbContextOptions<DirectoryContext> options) : base(options) { }

        public virtual DbSet<GetDirectoryHeadersResult> GetDirectoryHeadersResult { get; set; }
    }
}
