using Afiliados.Core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Afiliados.Infraestructure.Data.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> modelBuilder)
        {
            modelBuilder.HasKey(e => e.Id)
               .HasName("Pk_Categoria");
            modelBuilder.Property(e => e.Nombre)
                   .HasMaxLength(50)
                   .IsUnicode(false);
        }
    }
}
