using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BDs_JR_para_API_desde_cero.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BDs_JR_para_API_desde_ceroContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BDs_JR_para_API_desde_ceroContext") ?? throw new InvalidOperationException("Connection string 'BDs_JR_para_API_desde_ceroContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
