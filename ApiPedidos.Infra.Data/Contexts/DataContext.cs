using ApiPedidos.Domain.Entities;
using ApiPedidos.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        //construtor para inicializar a classe por meio de injeção de dependência
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //declarar uma propriedade DbSet para cada entidade
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Endereco>? Endereco { get; set; }
        public DbSet<Cobranca>? Cobranca { get; set; }
        public DbSet<ItemPedido>? ItemPedido { get; set; }
        public DbSet<Pedido>? Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new CobrancaMap());
            modelBuilder.ApplyConfiguration(new ItemPedidoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
        }
  
    }
}
