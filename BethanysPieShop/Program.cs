using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPieRepository, PieRepository>();
builder.Services.AddScoped<ICategoryReporsitory, CategoryRepository>();
builder.Services.AddScoped<IShoppingCart, ShoppingCart>( sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<BethanysPieShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});
var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
app.UseDeveloperExceptionPage();
}
app.UseSession();
app.MapDefaultControllerRoute();
//DbInitializer.Seed(app);
app.Run();