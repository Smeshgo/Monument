using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S9LJBNU\MONUMENTBD;Initial Catalog=MlynDB;Integrated Security=True");
        }

        #region model
        public DbSet<Сustomer> Сustomers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<CategoryMaterial> CategoryMaterials { get; set; }
        public DbSet<CategoryPhoto> CategoryPhotos { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Monument> Monuments { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Worker> Workers { get; set; }
        #endregion

    }
}
