using Domain.Interface;
using Infrastructure.Persistance;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Shop.Controllers.Service;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddScoped<IBlogCategoryService, BlogCategoryService>();
//builder.Services.AddTransient<IBlogService, BlogService>();
//builder.Services.AddSingleton<ICategoryProductService, CategoryProductService>();
//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<IRoleService, RoleService>();
//builder.Services.AddScoped<ISliderService, SliderService>();
//builder.Services.AddScoped<IUserService, UserService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShopContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

//app.MapControllerRoute(
//    name: "Areas",
//    pattern: "{area=Admin}/{controller=Role}/{action=Index}/{id?}");

app.Run();
