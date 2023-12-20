using Microsoft.EntityFrameworkCore;
using MusteriProject.Models;

namespace MusteriProject.Dataa
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Musteri> Musteriler { get; set; }
    }
}
