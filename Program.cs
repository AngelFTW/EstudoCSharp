using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using SalesWebMVC.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using SalesWebMVC.Services;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SalesWebMVCContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SalesWebMVCContext"), builder => builder.MigrationsAssembly("SalesWebMVC")));


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();

var app = builder.Build();

var enUS = new CultureInfo("en-US");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(enUS),
    SupportedCultures = new List<CultureInfo> { enUS },
    SupportedUICultures = new List<CultureInfo> { enUS }
};
app.UseRequestLocalization(localizationOptions);


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    using var serviceScope = app.Services.CreateScope();
    var seedingService = serviceScope.ServiceProvider.GetRequiredService<SeedingService>();
    seedingService.Seed();
}


app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();