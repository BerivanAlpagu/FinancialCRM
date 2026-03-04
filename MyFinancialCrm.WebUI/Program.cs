using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.BusinessLayer.Concrete;
using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index/"; // Yetkisi olmayan buraya yönlendirilir
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20); // 20 dakika iþlem yapýlmazsa çýkýþ yapar
    });

// Add services to the container.
builder.Services.AddControllersWithViews();

// DataAccessLayer ve BusinessLayer arasýndaki baðlantýlar
builder.Services.AddScoped<IBankDal, EfBankRepository>();
builder.Services.AddScoped<IBankService, BankManager>();

builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IBillDal, EfBillRepository>();
builder.Services.AddScoped<IBillService, BillManager>();

builder.Services.AddScoped<IExpendDal, EfExpendRepository>();
builder.Services.AddScoped<IExpendService, ExpendManager>();

builder.Services.AddScoped<IBankProcessDal, EfBankProcessRepository>();
builder.Services.AddScoped<IBankProcessService, BankProcessManager>();

builder.Services.AddScoped<IUserDal, EfUserRepository>();
builder.Services.AddScoped<IUserService, UserManager>();
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

app.UseAuthentication(); // Kimlik doðrulama
app.UseAuthorization();  // Yetkilendirme

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}"); // Home yerine Dashboard yazdýk

app.Run();
