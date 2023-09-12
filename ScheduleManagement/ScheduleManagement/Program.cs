using Data.Interfaces;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using ScheduleManagement.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IScheduleRepository, ScheduleRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddDbContextFactory<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
