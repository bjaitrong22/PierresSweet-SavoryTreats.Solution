using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using PierresSweetAndSavoryTreats.Models;

namespace PierresSweetAndSavoryTreats
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<PierresSweetAndSavoryTreatsContext>(
        dbContextOptions => dbContextOptions
        .UseMySql(
          builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
        )
      );

      builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<PierresSweetAndSavoryTreatsContext>()
        .AddDefaultTokenProviders();

      // builder.Services.Configure<IdentityOptions>(options =>
      // {
      //   options.Password.RequireDigit = true;
      //   options.Password.RequireLowercase = true;
      //   options.Password.RequireNonAlphanumeric = true;
      //   options.Password.RequireUppercase = true;
      //   options.Password.RequiredLength = 8;
      //   options.Password.RequiredUniqueChars = 8;

      // });

      WebApplication app = builder.Build();

      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthentication();
      app.UseAuthorization();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run(); 
    }
  }
}