using BSCodeModels_Lib;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BSCodeAPI.Data
{
    public class BSCodeDbContext : DbContext
    {
        public BSCodeDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { set; get; }
        public DbSet<Trainer> Trainers { set; get; }
        public DbSet<About> Abouts { set; get; }
        public DbSet<Event> Events { set; get; }
    }
}
