using NovoCuidar_MVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>(options => options.UseMySql("server=localhost;initial catalog=NovoCuidar_MVC;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36 - mysql")));


var app = builder.Build();

//builder.Services.AddDbContext<Contexto>(options => options.UseMySql("server=localhost;initial catalog=NovoCuidar_MVC;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36 - mysql")));

//builder.Services.AddDbContext<Contexto>
//    (options => options.UseMySql(
//        "server=localhost;initial catalog=", Microsoft.EntityFrameworkCore.ServerVersion.Parse("6.0.36-mysql")));

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
