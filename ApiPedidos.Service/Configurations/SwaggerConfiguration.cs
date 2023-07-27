using ApiPedidos.Domain.Entities;
using Microsoft.OpenApi.Models;

namespace ApiPedidos.Service.Configurations
{
    public class SwaggerConfiguration
    {
        public static void AddSwagger(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = @"API para controle de pedidos",
                Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Rafaela Silva",
                        Email = "rafaela.silva3879@outlook.com",
                        Url = new
                Uri("https://github.com/rafaela-silva3879?tab=repositories")
                    }
                });
            });
        }
    }
}
