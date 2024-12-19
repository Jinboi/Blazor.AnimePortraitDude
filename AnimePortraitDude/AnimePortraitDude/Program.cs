using AnimePortraitDude.Components;
using AnimePortraitDude.Models;
using AnimePortraitDude.Services;
using Microsoft.EntityFrameworkCore;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IProductService, AnimePortraitDude.Services.ProductService>();

builder.Services.AddDbContext<ProductDbContext>(c =>
    c.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


StripeConfiguration.ApiKey = "sk_test_51QUiPNAXmngyOhkFMMpHZCLastk0iBzn3KTpdPOMoW8HGxPGcWyOjtI0V9WNY7DjLM2E1CuEicTFraVdQvKjbZhM00Bo5N923u";

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
