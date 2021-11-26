using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonumentMlyn.DAL.Entities;

namespace MonumentMlyn.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public ApplicationDbContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Salary>().HasKey(u => new{u.Date, u.WorkerId}); 
            builder.Entity<Salary>().HasOne(s => s.Worker).WithMany(c => c.Salary).IsRequired(); 
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-S9LJBNU\MONUMENTBD;Initial Catalog=MlynDB;Integrated Security=True");
        //}

        #region model
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Monument> Monuments { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Worker> Workers { get; set; }
        #endregion

    }
}
