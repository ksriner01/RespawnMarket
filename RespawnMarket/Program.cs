////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Full commenting of the Program.cs file
//
// The Program.cs file is used to configure and initiate the RespawnMarket web application. All of the
// services are initiated in this class file and the app itself is ran at the end of the class when
// all services have been built. The MVC Controllers, Razor Pages, and Blazor are all initiated in this
// class.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using Microsoft.EntityFrameworkCore;
using RespawnMarket.Models;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Allows for the store database connection string to be obtained and declares that the SQL server is being used.
builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:RespawnMarketConnection"]);
});
// Allows for each HTTP request to have its own repository object.
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();
builder.Services.AddScoped<IOrderRepository, EFOrderRepository>();

builder.Services.AddRazorPages();
// Enables sessions for individual clients.
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
// Allows for the same Cart object to be used to satisfy related requests for Cart interests per session.
builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddServerSideBlazor();
// Allows for the identity database connection string to be obtained and declares that the SQL server is being used.
builder.Services.AddDbContext<AppIdentityDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:IdentityConnection"]));
// Sets up identity services.
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppIdentityDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Allows for the error page to display when an unhandled exception occurs.
    app.UseExceptionHandler("/error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Uses en-US localization.
app.UseRequestLocalization(opts =>
{
    opts.AddSupportedCultures("en-US")
    .AddSupportedUICultures("en-US")
    .SetDefaultCulture("en-US");
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
// Middleware components for implementing security policy.
app.UseAuthentication();
app.UseAuthorization();

// Provides a URL scheme for different situations accounting for pagination and categories.
app.MapControllerRoute("catpage",
    "{category}/Page{productPage:int}",
    new { Controller = "Home", action = "Index" });
app.MapControllerRoute("page", "Page{productPage:int}",
    new { Controller = "Home", action = "Index", productPage = 1 });
app.MapControllerRoute("category", "{category}",
    new { Controller = "Home", action = "Index", productPage = 1 });
app.MapControllerRoute("pagination",
    "Products/Page{productPage}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapDefaultControllerRoute();
app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");

// Ensures that the database is populated for both the store entities and user account entities.
SeedData.EnsurePopulated(app);
IdentitySeedData.EnsurePopulated(app);

app.Run();
