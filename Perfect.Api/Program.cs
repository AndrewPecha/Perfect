using Perfect.Api;
using Perfect.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices(builder.Configuration);
builder.Build()
    .RegisterApplication()
    .Run();