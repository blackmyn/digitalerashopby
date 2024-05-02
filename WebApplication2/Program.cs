using BLL.Interfaces;
using BLL.Services;
using DLL.DB;
using DLL.Interfaces;
using DLL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connect = builder.Configuration.GetConnectionString("default");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connect));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
    .AddRoles<IdentityRole>().AddDefaultTokenProviders();

builder.Services.AddAutoMapper(typeof(BLL.Mappers.ApplicationUserMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.BrandMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.CartMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.CategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.DeliveryMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.OrderItemMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.OrderMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.PaymentMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.ReviewMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.ProdSpecMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.SpecificationMappingProfile));

builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IApplicationUserService, ApplicationUserService>();

builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();

builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartService, CartService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IDeliveryRepository, DeliveryRepository>();
builder.Services.AddScoped<IDeliveryService, DeliveryService>();

builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IReviewService, ReviewService>();

builder.Services.AddScoped<IProdSpec, ProdSpecRepository>();
builder.Services.AddScoped<IProcSpecService, ProdSpecService>();

builder.Services.AddScoped<ISpecificationRepository, SpecificationRepository>();
builder.Services.AddScoped<ISpecificationServce, SpecificationService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
var roleManager = scope.ServiceProvider.GetRequiredService<Microsoft.AspNetCore.Identity.RoleManager<IdentityRole>>();
var roles = new[] { "Administrator", "StatisticManager", "Client", "Manager" };

foreach (var role in roles)
{
if (!await roleManager.RoleExistsAsync(role))
{
await roleManager.CreateAsync(new IdentityRole(role));
}
}
}
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<Microsoft.AspNetCore.Identity.UserManager<ApplicationUser>>();
    string email = "admin@admin.com";
    string password = "Admin1!";
    string name = "AdminUser1";
    string email1 = "statisticmanager@mail.ru";
    string password1 = "StatisticManager1!";
    string name1 = "ClientManager1";
    string email2 = "client@mail.ru";
    string password2 = "Client1!";
    string name2 = "Client1";
    string email3 = "manager@mail.ru";
    string password3 = "Manager1!";
    string name3 = "Manager1";
    if (await userManager.FindByEmailAsync(email) == null)
    {
        var user = new ApplicationUser();
        user.Email = email;
        user.UserName = email;
        user.FirstName = "Иван";
        user.LastName = "Сергеенко";
        user.Address = "пер. Революционнный, д.15А кв.1";
        await userManager.CreateAsync(user, password);
        await userManager.AddToRoleAsync(user, "Administrator");

    }
    if (await userManager.FindByEmailAsync(email2) == null)
    {

        var user2 = new ApplicationUser();
        user2.Email = email2;
        user2.UserName = email2;
        user2.FirstName = "Дарья";
        user2.LastName = "Василькова";
        user2.Address = "ул. Тенистая, д.13";
        await userManager.CreateAsync(user2, password2);
        await userManager.AddToRoleAsync(user2, "Client");
    }
    if (await userManager.FindByEmailAsync(email1) == null)
    {
        var user1 = new ApplicationUser();
        user1.Email = email1;
        user1.UserName = email1;
        user1.FirstName = "Алексей";
        user1.LastName = "Самойлов";
        user1.Address = "ул. Советская, д.34 кв.11";
        await userManager.CreateAsync(user1, password1);
        await userManager.AddToRoleAsync(user1, "StatisticManager");
    }
    if (await userManager.FindByEmailAsync(email3) == null)
    {
        var user3 = new ApplicationUser();
        user3.Email = email1;
        user3.UserName = email1;
        user3.FirstName = "Никита";
        user3.LastName = "Сергеенко";
        user3.Address = "ул. Зеленая, д.12 кв.143";
        await userManager.CreateAsync(user3, password1);
        await userManager.AddToRoleAsync(user3, "Manager");
    }
}
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
