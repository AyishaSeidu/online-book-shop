using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineBookShop.Web;
using OnlineBookShop.Web.HttpRepositories;
using OnlineBookShop.Web.HttpRepositories.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7129") });
builder.Services.AddScoped<IBookHttpRepo, BookHttpRepo>();
builder.Services.AddScoped<ICartHttpRepo, CartHttpRepo>();
builder.Services.AddScoped<IGenreHttpRepo, GenreHttpRepo>();
builder.Services.AddScoped<IManageBooksLocalStorageHttpRepo, ManageBooksLocalStorageHttpRepo>();
builder.Services.AddScoped<IManageCartLocalStorageHttpRepo, ManageCartLocalStorageHttpRepo>();

await builder.Build().RunAsync();
