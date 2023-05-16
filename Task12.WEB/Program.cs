using Microsoft.EntityFrameworkCore;
using Task12.BL.DALModels;
using Task12.BL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Task12Context>(options => { 
    options.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
});

// We need to add Automapper profiles from all the assemblies
builder.Services.AddAutoMapper(
    typeof(Task12.WEB.Mapping.AutomapperProfile),
    typeof(Task12.BL.Mapping.AutomapperProfile));

builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();
