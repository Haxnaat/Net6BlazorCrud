using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SportingApp.Client;
using SportingApp.Client.Services.AuthService;
using SportingApp.Client.Services.CustomerService;
using SportingApp.Client.Services.IncidentService;
using SportingApp.Client.Services.ProductService;
using SportingApp.Client.Services.RegistrationService;
using SportingApp.Client.Services.TechnicianService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<ICustomerUiService, CustomerUiService>();
builder.Services.AddScoped<ITechnicianUiService, TechnicianUiService>();
builder.Services.AddScoped<IProductUiService, ProductUiService>();
builder.Services.AddScoped<IIncidentUiService, IncidentUiService>();
builder.Services.AddScoped<IAuthUiService, AuthUiService>();
builder.Services.AddScoped<IRegistrationUiService, RegistrationUiService>();

await builder.Build().RunAsync();
