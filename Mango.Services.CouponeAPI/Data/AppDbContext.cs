using Mango.Services.CouponeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponeAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Coupon> Coupons { get; set; }
    }
}
