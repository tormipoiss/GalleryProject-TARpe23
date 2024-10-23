using GalleryProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryProject.Data
{
    public class GalleryDbContext : DbContext
    {
        public GalleryDbContext(DbContextOptions<GalleryDbContext> options)
            : base(options) { }

        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<WorkOfArt> WorksOfArt { get; set; }
        public DbSet<WorkOfArtGroup> WorksOfArtGroups { get; set; }
    }
}
