using ComplianceApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ComplianceApp
{
    public class ApplicationDbcontext :DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options):
            base(options)
        {
            
        }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<ComplianceItem> ComplianceItems{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComplianceItem>()
            .HasKey(c => new { c.EpisodeId, c.StartTime, c.EndTime });
        }
    }
}
