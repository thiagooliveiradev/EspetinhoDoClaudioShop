using EspetinhoDoClaudioShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISkewerRepository, SkewerRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EspetinhoDoClaudioDbContext>(options => { 

    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:EspetinhoDoClaudioDbContextConnection"]);
});


var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{ 
    app.UseDeveloperExceptionPage(); 
}

app.MapDefaultControllerRoute();       
  
app.Run();
