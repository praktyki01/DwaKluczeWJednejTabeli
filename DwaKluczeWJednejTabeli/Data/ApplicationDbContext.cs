using DwaKluczeWJednejTabeli.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DwaKluczeWJednejTabeli.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Druzyna> Druzyna { get; set; }
        public DbSet<Zawodnik> Zawodnik { get; set; }
        public DbSet<Mecz> Mecz { get; set; }
        public DbSet<Statystyki> Statystyki { get; set; }
        public DbSet<Tabela> Tabela { get; set; }
        public DbSet<Sedzia> Sedzia { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Mecz>()
            .HasOne(m => m.GoscieDruzyna)
            .WithMany(t => t.MeczGoscies)
            .HasForeignKey(m => m.GoscieDruzynaId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mecz>()
            .HasOne(m => m.GospodarzeDruzyna)
            .WithMany(t => t.MeczGospodarzes)
            .HasForeignKey(m => m.GospodarzeDruzynaId)
            .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
