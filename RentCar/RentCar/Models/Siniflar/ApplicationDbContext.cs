using Microsoft.EntityFrameworkCore;


namespace RentCar.Models.Siniflar
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DILCE;database=AracDb; integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<Arac> aracs { get; set; }
        public DbSet<Admin> admins { get; set; }   
        public DbSet<Uye> uye { get; set; }
        public DbSet<Yorum> yorum { get; set; }
    }
}
