using Microsoft.EntityFrameworkCore;
using MVC_TravelGuide.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TravelGuideDbContext>(options =>
    options.UseNpgsql(
        "Host=localhost;Port=12600;Database=travel_db;Username=travel_user;Password=travel_password"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();