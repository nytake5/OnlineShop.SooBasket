using Microsoft.EntityFrameworkCore;
using OnlineShop.SooBasket.EFDal.DbContexts;
using OnlineShop.SooBasket.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var config = builder.Configuration
    .GetSection("EnvironmentVariables")
    .Get<EnvironmentVariables>();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<NpgsqlContext>(
    options =>
    {
        options.UseNpgsql(config?.NpgsqlConnectionString);
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    //app.UseHsts();
}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

//app.MapFallbackToFile("index.html");
await app.RunAsync();