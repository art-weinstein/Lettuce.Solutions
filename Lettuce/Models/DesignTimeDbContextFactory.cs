using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Lettuce.Models
{
  public class LettuceContextFactory : IDesignTimeDbContextFactory<LettuceContext>
  {
    LettuceContext IDesignTimeDbContextFactory<LettuceContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json")
      .Build();

      var builder = new DbContextOptionsBuilder<LettuceContext>();
      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new LettuceContext(builder.Options);
    }
  }
}