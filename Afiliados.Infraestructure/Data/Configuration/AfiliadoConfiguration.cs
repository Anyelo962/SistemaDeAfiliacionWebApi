using Afiliados.Core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Afiliados.Infraestructure.Data.Configuration
{
    public class AfiliadoConfiguration : IEntityTypeConfiguration<Afiliado>
    {
        public void Configure(EntityTypeBuilder<Afiliado> modelBuilder)
        {
            modelBuilder.HasKey(e => e.Id)
                .HasName("Pk_idAfiliado");
    
                modelBuilder.Property(e => e.Apellido)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                modelBuilder.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                modelBuilder.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
        }
    }
}
