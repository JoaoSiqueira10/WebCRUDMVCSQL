using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQL.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}
