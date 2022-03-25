using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierresSavoryAndSweet.Models
{
  public class PierresSavoryAndSweetContextFactory : IDesignTimeDbContextFactory<PierresSavoryAndSweetContext>
  {

    PierresSavoryAndSweetContext IDesignTimeDbContextFactory<PierresSavoryAndSweetContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierresSavoryAndSweetContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new PierresSavoryAndSweetContext(builder.Options);
    }
  }
}