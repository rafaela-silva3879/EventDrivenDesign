using ApiPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Infra.Data.Mappings
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
          
            builder.Property(p=>p.DataHora).IsRequired();
            builder.Property(p=>p.DetalhesPagamento).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ProtocoloPagamento).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Status).IsRequired();
           
            builder.Property(p => p.Valor).HasColumnType("decimal(18,2)").IsRequired();


            builder.Property(p => p.ClienteId).IsRequired();

            builder.HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}