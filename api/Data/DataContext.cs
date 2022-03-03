using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<SuperHero> superHeroes { get; set; }
        public DbSet<Employee> employees { get; set; }
    }

    }

