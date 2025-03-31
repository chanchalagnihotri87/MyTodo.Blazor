using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyTodo.Blazor.Client.Services;
using MyTodo.Blazor.Client.Services.API.Clients;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.ConfigureApiClients(builder.Configuration);

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
