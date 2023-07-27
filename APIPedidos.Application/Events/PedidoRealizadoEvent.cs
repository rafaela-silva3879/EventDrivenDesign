using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Application.Events
{
    /// <summary>
    /// classe para modelar o evento: Pedido Realizado
    /// </summary>
    public class PedidoRealizadoEvent : BaseEvent
    {
        public string? DetalhesPedido { get; set; }
    }
}
