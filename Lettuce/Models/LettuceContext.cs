using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lettuce.Models
{
  public class LettuceContext :IdentityDbContext<ApplicationUser>
  {
  public DbSet<LettucePlant> LettucePlants {get;set;}
  public DbSet<Brand> Brands {get;set;}
  public DbSet<BrandLettucePlant> BrandLettucePlants {get;set;}
  public DbSet<UserLettucePlant> UserLettucePlants {get;set;}

    public LettuceContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
