using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPedidos.Domain.Entities;

namespace ApiPedidos.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository
: IBaseRepository<Pedido, Guid>
    {
    }
}
