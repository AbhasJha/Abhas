using FizzBuzz.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRule, FizzBuzzRule>();
builder.Services.AddScoped<IRule, FizzRule>();
builder.Services.AddScoped<IRule, BuzzRule>();
builder.Services.AddScoped<IFizzBuzzService, FizzBuzzService>();
builder.Services.AddScoped<IWeekdayVerifier, WeekdayVerifier>();

builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromMinutes(60);//You can set Time   
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

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=FizzBuzz}/{action=Index}/{id?}");

app.Run();
