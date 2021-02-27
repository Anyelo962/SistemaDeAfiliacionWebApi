using Afiliados.Core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Afiliados.Infraestructure.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> modelBuilder)
        {
          
                modelBuilder.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                modelBuilder.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                modelBuilder.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_Productos_Categoria");
        }
    }
}
