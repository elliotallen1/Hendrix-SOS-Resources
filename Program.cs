using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HendrixSOSResources.Data;

// <ms_docref_import_types>
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
// </ms_docref_import_types>

// <ms_docref_add_msal>
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
IEnumerable<string>? initialScopes = builder.Configuration.GetSection("DownstreamApi:Scopes").Get<string[]>();


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SOSContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SOSContext") ?? throw new InvalidOperationException("Connection string 'SOSContext' not found.")));


builder.Services.AddMicrosoftIdentityWebAppAuthentication(builder.Configuration, "AzureAd")
    .EnableTokenAcquisitionToCallDownstreamApi(initialScopes)
        .AddDownstreamApi("DownstreamApi", builder.Configuration.GetSection("DownstreamApi"))
        .AddInMemoryTokenCaches();
// </ms_docref_add_msal>


// <ms_docref_add_default_controller_for_sign-in-out>
builder.Services.AddRazorPages().AddMvcOptions(options =>
    {
        var policy = new AuthorizationPolicyBuilder()
                      .RequireAuthenticatedUser()
                      .Build();
        options.Filters.Add(new AuthorizeFilter(policy));
    }).AddMicrosoftIdentityUI();
// </ms_docref_add_default_controller_for_sign-in-out>

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<GraphMailService>();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();
// </ms_docref_enable_authz_capabilities>

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();


app.Run();
