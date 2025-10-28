using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Abstract;
using ServiceLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FashiDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnect"),b=>b.MigrationsAssembly("FashiApp"));
});

//repolar
builder.Services.AddScoped<IProductDAL, EFProductRepository>();
builder.Services.AddScoped<ICategoryDal, EFCategoryRepository>();
builder.Services.AddScoped<ISizeDAL, EFSizeRepository>();
builder.Services.AddScoped<IColorDAL, EFColorRepository>();
//servisler
builder.Services.AddScoped<IColorService, ColorManager>();
builder.Services.AddScoped<ISizeService, SizeManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

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
