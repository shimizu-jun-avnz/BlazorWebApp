using Microsoft.AspNetCore.ResponseCompression;
using BlazorWebApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<EmployeeDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("MySQL")));

builder.Services.AddDbContext<DepartmentCodeMasterDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("MySQL")));

builder.Services.AddDbContext<DivisionCodeMasterDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("MySQL")));

builder.Services.AddDbContext<GeneralCodeMasterDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("MySQL")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
