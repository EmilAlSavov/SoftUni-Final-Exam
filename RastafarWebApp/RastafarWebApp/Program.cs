using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RastafarWebApp.Data;
using RastafarAppServices.Services;
using RastafarAppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using HiparAppServices.Services.Admin;
using HiparAppServices.Admin;
using HiparAppData.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RastafarContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => 
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 8;
})                                                                                                                  
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<RastafarContext>();
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ICampService, CampService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICampTypeService, CampTypeService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<ITraveltypeService, TraveltypeService>();
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
});
//builder.Services.AddCors(options =>
//{
//	options.AddPolicy(name: "JqueryApi",
//					  builder =>
//					  {
//						  builder.WithOrigins("/*");
//					  });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error/Index/500");
    app.UseStatusCodePagesWithRedirects("/Error/Index?statusCode={0}");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.UseCors("JqueryApi");

app.Run();
