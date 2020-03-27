using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public BakeryContext(DbContextOptions options) : base(options) { }
  }
}