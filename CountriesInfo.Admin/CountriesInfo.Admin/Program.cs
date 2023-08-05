var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure the Python Flask HttpClient for the Countries API
builder.Services.AddHttpClient("FlaskCountriesAPI", client =>
{
    client.BaseAddress = new Uri("http://127.0.0.1:5000/");
    // Add any additional configurations for the API
});

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
