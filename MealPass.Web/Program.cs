using Microsoft.EntityFrameworkCore;
using MealPass.Web.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient("MealPassAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7266/api/"); // replace with your API URL
});


builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.WebHost.UseUrls("http://0.0.0.0:5245");

var app = builder.Build();
app.UseSession();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MealPass}/{action=Login}/{id?}");

app.Run();
