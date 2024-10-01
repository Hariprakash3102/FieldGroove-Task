using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Infrastructure.Common;
using FieldGroove.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FieldDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FieldGroove")));

builder.Services.AddScoped(typeof(IGenericsRepository<>), typeof(GenericsRepository<>));

builder.Services.AddScoped<IRegisterRepository, RegistorRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Register}/{action=Register}/{id?}");

app.Run();
