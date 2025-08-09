using Microsoft.EntityFrameworkCore;
using TravelApp.Components;
using TravelApp.Data;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// --- DB: point EF Core at Data/Travel.sqlite ---
var dbPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "Travel.sqlite");
builder.Services.AddDbContext<TravelContext>(opts => opts.UseSqlite($"Data Source={dbPath}"));

// --- Razor Components (new Blazor template) ---
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// --- Pipeline (keep your defaults) ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// --- Ensure tables exist (creates if missing) ---
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<TravelContext>();
    db.Database.EnsureCreated(); // or db.Database.Migrate() if you use migrations
}

app.Run();
