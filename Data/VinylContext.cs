using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VinylManager.Models;

namespace VinylManager.Data
{
    public class VinylContext : IdentityDbContext
    {
        public VinylContext(DbContextOptions<VinylContext> options)
            : base(options) { }

        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronic", Description = "Electronic music genre." },
                new Category { Id = 2, Name = "Progressive Rock", Description = "Progressive rock genre." }
            );

            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, Name = "Tangerine Dream", Bio = "Pioneering electronic musicians; atmospheric, cinematic soundscapes." },
                new Artist { Id = 2, Name = "Isao Tomita", Bio = "Japanese synthesist; cinematic, otherworldly music." },
                new Artist { Id = 3, Name = "Pink Floyd", Bio = "Experimental psychedelic band; emotive, introspective themes." }
            );

            modelBuilder.Entity<Vinyl>().HasData(
                new Vinyl
                {
                    Id = 1,
                    Title = "Phaedra",
                    Year = 1974,
                    Condition = "Excellent",
                    Notes = "Hypnotic, cosmic.",
                    ArtistId = 1,
                    CategoryId = 1
                },
                new Vinyl
                {
                    Id = 2,
                    Title = "The Bermuda Triangle",
                    Year = 1978,
                    Condition = "Very Good",
                    Notes = "Ethereal, mysterious.",
                    ArtistId = 2,
                    CategoryId = 1
                },
                new Vinyl
                {
                    Id = 3,
                    Title = "Obscured by Clouds",
                    Year = 1972,
                    Condition = "Good",
                    Notes = "Mellow, introspective.",
                    ArtistId = 3,
                    CategoryId = 2
                }
            );

            modelBuilder.Entity<Vinyl>()
                .HasOne(v => v.Artist)
                .WithMany(a => a.Vinyls)
                .HasForeignKey(v => v.ArtistId);

            modelBuilder.Entity<Vinyl>()
                .HasOne(v => v.Category)
                .WithMany(c => c.Vinyls)
                .HasForeignKey(v => v.CategoryId);
        }
    }
}
