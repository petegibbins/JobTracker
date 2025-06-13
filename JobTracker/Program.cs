using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using JobTracker;
using JobTracker.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<JobService>();
builder.Services.AddOidcAuthentication(options =>
{
    options.ProviderOptions.Authority = "https://dev-b87msvogmhqskscw.uk.auth0.com";
    options.ProviderOptions.ClientId = "eZLDTyqZTASKqByAykURyqUtbxTYcv1S";
    options.ProviderOptions.ResponseType = "code";
    options.ProviderOptions.DefaultScopes.Add("openid");
    options.ProviderOptions.DefaultScopes.Add("profile");
    options.ProviderOptions.DefaultScopes.Add("email");
});
await builder.Build().RunAsync();
