using BlazorDKJ.Data;
using BlazorDKJ.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ITowarService, TowarService>();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IJmService ,JmService>();
builder.Services.AddDbContext<mczeContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("mczeDatabase")));

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTQzODU5QDMyMzAyZTM0MmUzMFlhK0xDVjkzQllJbGwyNjNTTThDenZtd1NHQUpZN3djQnZ3aVcya3ZmR0U9");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
