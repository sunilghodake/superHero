
namespace superHero.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
          
        public DbSet<SuperHero> Anguler_Api { get; set; }
    }
}
