using CV.Models;
using Microsoft.EntityFrameworkCore;

namespace CV.Contexts
{
    public class CvContext : DbContext
    {
        public CvContext(DbContextOptions<CvContext> options)
            : base(options)
        {
        }

        public CvContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}