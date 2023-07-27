using ApiPedidos.Application.Interfaces;
using ApiPedidos.Application.Services;
using ApiPedidos.Domain.Interfaces.Repositories;
using ApiPedidos.Domain.Interfaces.Services;
using ApiPedidos.Domain.Services;
using ApiPedidos.Infra.Data.Contexts;
using ApiPedidos.Infra.Data.Repositories;
using ApiPedidos.Infra.EventBus.Producers;
using ApiPedidos.Infra.EventBus.Settings;
using Microsoft.EntityFrameworkCore;

namespace ApiPedidos.Services.Configurations
{
    public class DependencyInjectionConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<MessageBrokerSettings>
                (configuration.GetSection("MessageBrokerSettings"));

            //capturar a connectionstring do banco de dados (appsettings.json)
            var connectionstring = configuration.GetConnectionString("Conexao");

            //mapear a injeção de dependência para a classe 'SqlServerContext' localizada
            //no projeto Repository (classe que irá fazer a conexão com o banco de dados)
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionstring));


            services.AddTransient<IPedidoAppService, PedidoAppService>();
            services.AddTransient<IPedidoDomainService, PedidoDomainService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPedidoProducer, PedidoProducer>();
            //services.AddTransient<DataContext>();
        }
    }
}
