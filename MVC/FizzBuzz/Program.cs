using FizzBuzz;
using FizzBuzz.Services;
using System.Collections.Generic;
using System.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRule, FizzBuzzRule>();
builder.Services.AddScoped<IRule, FizzRule>();
builder.Services.AddScoped<IRule, BuzzRule>();
builder.Services.AddScoped<IFizzBuzzService, FizzBuzzService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=FizzBuzz}/{action=Index}/{id?}");

app.Run();



//builder.Services.AddScoped<IFizzBuzzService>(_=> new  FizzBuzzService(new List <IRule>()));

//Startup s = new Startup();
//s.ConfigureServices();
