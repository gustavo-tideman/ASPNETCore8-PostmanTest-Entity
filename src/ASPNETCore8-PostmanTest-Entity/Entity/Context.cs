using Microsoft.EntityFrameworkCore;

namespace WebAPI.Entity
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<PostmanPipeline> PostmanPipeline { get; set; }
    }
}
