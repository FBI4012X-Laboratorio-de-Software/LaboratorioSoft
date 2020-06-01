using Microsoft.EntityFrameworkCore;


namespace LaboratoryPosts.Model
{
    public class LaboratoryDbContext : DbContext
    {
        public LaboratoryDbContext(DbContextOptions<LaboratoryDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Imgpost> ImgPosts { get; set; }
    }
}
