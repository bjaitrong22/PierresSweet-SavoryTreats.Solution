using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PierresSweetAndSavoryTreats.Models
{
  public class PierresSweetAndSavoryTreatsContext: IdentityDbContext<ApplicationUser>
  {  
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }

    public PierresSweetAndSavoryTreatsContext(DbContextOptions options) : base(options) {}
  }
}