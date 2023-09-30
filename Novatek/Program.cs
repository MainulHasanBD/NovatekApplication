using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Novatek.Data;
using Novatek.Models.Entities;
var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

//builder.Services.AddDbContext<NovatekDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("NovatekDbContext") ?? throw new InvalidOperationException("Connection string 'NovatekDbContext' not found.")));

//builder.Services.AddDefaultIdentity<IdentityUser>().AddDefaultTokenProviders()
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<NovatekDbContext>();

builder.Services.AddDbContext<NovatekDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NovatekDbContext"));
});

builder.Services.AddIdentity<IdentityCustomUser, IdentityRole>()
                .AddEntityFrameworkStores<NovatekDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Account/Login";
    options.Cookie.Name = "$user_1234567890";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromSeconds(60 * 5);
    options.LoginPath = "/Account/Login";
});






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
app.UseSession();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();
//app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
