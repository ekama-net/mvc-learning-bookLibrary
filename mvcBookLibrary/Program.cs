using Microsoft.EntityFrameworkCore;
using mvcBookLibrary.Data;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<mvcBookLibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("mvcBookLibraryContext") ?? throw new InvalidOperationException("Connection string 'mvcBookLibraryContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

WebApplication? app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();
