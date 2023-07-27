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
    public class CobrancaMap : IEntityTypeConfiguration<Cobranca>
    {
        public void Configure(EntityTypeBuilder<Cobranca> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.ValorCobranca).HasColumnType("decimal(18,2)");

            builder.Property(c => c.PedidoId).IsRequired();

            builder.HasOne(c => c.Pedido)
            .WithOne(p => p.Cobranca)
            .HasForeignKey<Cobranca>(c => c.PedidoId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }

}