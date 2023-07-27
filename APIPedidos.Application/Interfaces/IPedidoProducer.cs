using ApiPedidos.Application.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Application.Interfaces
{
    /// <summary>
    /// Interface para definir a ação de escrita de uma mensagem no Message broker.
    /// </summary>
    public interface IPedidoProducer
    {
        Task Add(PedidoRealizadoEvent @event);
    }
}
