using Blog.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public BlogContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(x => x.HasKey(x => x.Id));
        }
    }
}
