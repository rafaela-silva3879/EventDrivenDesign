using ApiPedidos.Application.Interfaces;
using ApiPedidos.Application.Services;
using ApiPedidos.Infra.Data.Contexts;
using ApiPedidos.Infra.EventBus.Producers;
using ApiPedidos.Infra.EventBus.Settings;
using ApiPedidos.Service.Configurations;
using ApiPedidos.Services.Configurations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

SwaggerConfiguration.AddSwagger(builder);

// Registre a classe de configuração DependencyInjectionConfiguration
DependencyInjectionConfiguration.ConfigureServices(builder.Services, builder.Configuration);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.Configure<MessageBrokerSettings>
(builder.Configuration.GetSection("MessageBrokerSettings"));


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

//classe pra dizer quem pode ter acesso a essa api
CorsConfiguration.UseCors(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
public partial class Program { }