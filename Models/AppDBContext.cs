using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace RentaCar.Models
{
    public class AppDBContext:DbContext
    {
        private AppDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Arac> Aracs { get; set; }
    }
}
