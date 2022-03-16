using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.Objects;

namespace api.Data
{
    public class DataContext : DbContext
    {   public DataContext(DbContextOptions<DataContext> options) : base(options){
          
        }protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>().Property(b => b.SkillLevel).HasDefaultValue(4);
        }

        public DbSet<Department> departments { get; set; }
        public DbSet<SuperHero> superHeroes { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<Applicant> applicants{ get; set; }

       
    }

    }

