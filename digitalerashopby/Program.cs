using BLL.Interfaces;
using BLL.Services;
using DLL.DB;
using DLL.Interfaces;
using DLL.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var connect = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connect));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        options.LoginPath = "/Home/Login";
        options.AccessDeniedPath = "/Home/AccessDenied";
        options.SlidingExpiration = true;
        options.ReturnUrlParameter = string.Empty;
    });

builder.Services.AddAutoMapper(typeof(BLL.Mappers.ApplicationUserMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.BrandMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.CartMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.CategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.DeliveryMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.OrderItemMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.OrderMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.PaymentMappingProfile));
builder.Services.AddAutoMapper(typeof(BLL.Mappers.ReviewMappingProfile));
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

builder.Services.AddScoped<ISpecificationRepository, SpecificationRepository>();
builder.Services.AddScoped<ISpecificationServce, SpecificationService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//using (var scope = app.Services.CreateScope())
//{
//    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var roles = new[] { "Administrator", "ClientManager", "Client" };

//    foreach (var role in roles)
//    {
//        if (!await roleManager.RoleExistsAsync(role))
//        {
//            await roleManager.CreateAsync(new IdentityRole(role));
//        }
//    }
//}
//using (var scope = app.Services.CreateScope())
//{
//    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
//    string email = "admin@admin.com";
//    string password = "Admin1!";
//    string name = "AdminUser1";
//    string email1 = "clientmanager@mail.ru";
//    string password1 = "ClientManager1!";
//    string name1 = "ClientManager1";
//    string email2 = "client@mail.ru";
//    string password2 = "Client1!";
//    string name2 = "Client1";

//    if (await userManager.FindByEmailAsync(email) == null)
//    {
//        var user = new AppUser();
//        user.Email = email;
//        user.UserName = email;
//        user.Name = name;
//        await userManager.CreateAsync(user, password);
//        await userManager.AddToRoleAsync(user, "Administrator");

//    }
//    if (await userManager.FindByEmailAsync(email2) == null)
//    {

//        var user2 = new AppUser();
//        user2.Email = email2;
//        user2.UserName = email2;
//        user2.Name = name2;
//        await userManager.CreateAsync(user2, password2);
//        await userManager.AddToRoleAsync(user2, "Client");
//    }
//    //if (await userManager.FindByEmailAsync(email1) == null)
//    //{
//    //    var user1 = new AppUser();
//    //    user1.Email = email1;
//    //    user1.UserName = email1;
//    //    user1.Name = name1;
//    //    await userManager.CreateAsync(user1, password1);
//    //    await userManager.AddToRoleAsync(user1, "ClientManager");
//    //}

app.Run();