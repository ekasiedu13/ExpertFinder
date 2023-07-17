using ExpertFinderRct.Models;
namespace ExpertFinderRct.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseNpgsql((opt) => opt.);
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseNpgsql("Server=localhost;Database=superheroes;Port=5432;User ID=superheroes;Password=superheroes;");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityAlwaysColumns();
        }

        public DbSet<Expert> Experts { get; set; }
    }
}