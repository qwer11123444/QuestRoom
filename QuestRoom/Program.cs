using Microsoft.EntityFrameworkCore;
using QuestRoom.Components;
using QuestRoom.Database;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<QuestRoomContext>();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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

using (var ServiceScope = app.Services.CreateScope())
{
    var context = ServiceScope.ServiceProvider.GetRequiredService<QuestRoomContext>();
    context.Database.Migrate();
}

app.Run();