using PiLevels.Components;
using MudBlazor.Services;
using PiLevels.Services.Skill;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();

builder.Services.AddScoped<SkillService>();

builder.Services.AddAntiforgery(opts => opts.SuppressXFrameOptionsHeader = true);

var app = builder.Build();


// clear any X-Frame-Options and add a CSP frame-ancestors for Teams
app.Use(async (context, next) =>
{
    await next();

    // remove the default SAMEORIGIN header
    context.Response.Headers.Remove("X-Frame-Options");

    // allow framing only by Teams web
    context.Response.Headers.Append("Content-Security-Policy",
      "frame-ancestors https://teams.microsoft.com https://*.teams.microsoft.com;");
});

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
