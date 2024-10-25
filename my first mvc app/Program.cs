using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using my_first_mvc_app.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure the DbContext to use SQL Server
builder.Services.AddDbContext<my_first_mvc_appContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("my_first_mvc_appContext") ?? throw new InvalidOperationException("Connection string 'my_first_mvc_appContext' not found.")));

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Define routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

// Route for Product Summary
app.MapControllerRoute(
    name: "productSummary",
    pattern: "Products/ProductSummary",
    defaults: new { controller = "Products", action = "ProductSummary" });

// Route for filtering products by category
app.MapControllerRoute(
    name: "filterByCategory",
    pattern: "Products/FilterByCategory/{category?}",
    defaults: new { controller = "Products", action = "FilterByCategory" });

// Run the application
app.Run();
