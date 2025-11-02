using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TheaterReporting.Models
{
    public class TheatreDbContext : IdentityDbContext<Users>
    {

        public DbSet<AuthorJob> AuthorJobs { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Play> Plays { get; set; }

        public DbSet<PlayAuthors> PlayAuthors { get; set; }

        public DbSet<Report> Reports { get; set; }
        public TheatreDbContext(DbContextOptions<TheatreDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Performance>()
            .HasMany(p => p.Reports)
            .WithMany(r => r.Performances)
            .UsingEntity<Dictionary<string, object>>(
                "PerformanceReport",
                j => j.HasOne<Report>().WithMany().HasForeignKey("ReportId"),
                j => j.HasOne<Performance>().WithMany().HasForeignKey("PerformanceId"),
                j => {
                    j.Property<int>("PerformanceReportId")
                        .ValueGeneratedOnAdd();
                    j.HasKey("PerformanceReportId");
                }
            );
        }
    }
}
