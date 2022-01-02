using CRUD2.DataBase.Configurations;
using CRUD2.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD2.DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlogPostConfiguration());
        }
    }
}
