using BuberBreakfast.Services.Breakfasts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddScoped<IBreakfastService, BreakfastService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
