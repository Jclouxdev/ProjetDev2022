using App.Data;
using App.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRepository<Hero>, EFHeroRepository>();
builder.Services.AddScoped<IRepository<Monster>, EFMonsterRepository>();

builder.Services.AddAuthentication("AuthCookie").AddCookie("AuthCookie", options => {
  options.Cookie.Name = "AuthCookie";
});

// builder.Services.AddScope<IPlayerRepository<Player>>, EFPlayerRepository();

var connectionString = "server=localhost;user=root;password=my_password;database=DB-Gatcha";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

builder.Services.AddDbContext<AppDbContext>(
  dbContextOptions => dbContextOptions
    .UseMySql(connectionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors()
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints => {
  endpoints.MapControllers();
});

using (var scope = app.Services.CreateScope())
{
  scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();
  // Seeding
  scope.ServiceProvider.GetRequiredService<AppDbContext>().SeedHero();
  scope.ServiceProvider.GetRequiredService<AppDbContext>().SeedMonster();
  scope.ServiceProvider.GetRequiredService<AppDbContext>().SeedPlayer();
}

app.Run();
