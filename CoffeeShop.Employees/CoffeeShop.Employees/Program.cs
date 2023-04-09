using CoffeeShop.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContextFactory<EmployeeManagerDbContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagerDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // TODO: To be removed once we have .sqlproj 
    // WARNING: Don't do this in production, just useful for development
    using var scope = app.Services.CreateAsyncScope();
    using var context = scope.ServiceProvider.GetService<EmployeeManagerDbContext>();

    if (!await context!.Database.CanConnectAsync())
    {
        _ = await context!.Database.EnsureCreatedAsync();
    }
}
else
{
    app.UseExceptionHandler("/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
