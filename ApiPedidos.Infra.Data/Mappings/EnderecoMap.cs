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
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.ClienteId).IsRequired();

            builder.HasOne(e => e.Cliente)
                .WithOne(c => c.Endereco)
                .HasForeignKey<Endereco>(e => e.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}