using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPedidos.Domain.Entities;

namespace ApiPedidos.Infra.Data.Mappings
{
    public class ItemPedidoMap : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(r => r.Id);

            // Definindo o tipo de coluna para Preco
            builder.Property(p => p.Preco).HasColumnType("decimal(18, 2)"); 


            builder.Property(p => p.PedidoId).IsRequired();

            builder.HasOne(i => i.Pedido)
                 .WithMany(p => p.ItensPedido)
                 .HasForeignKey(i => i.PedidoId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }

}