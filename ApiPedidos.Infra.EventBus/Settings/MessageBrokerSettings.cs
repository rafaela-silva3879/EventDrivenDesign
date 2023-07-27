using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Infra.EventBus.Settings
{
    /// <summary>
    /// classe para capturar as configurações feitas no arquivo appsettings.json
    /// </summary>
    public class MessageBrokerSettings
    {
        public string? Url { get; set; }
        public string? Queue { get; set; }
    }
}
