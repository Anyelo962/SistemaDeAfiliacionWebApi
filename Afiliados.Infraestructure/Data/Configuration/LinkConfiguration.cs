using Afiliados.Core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Afiliados.Infraestructure.Data.Configuration
{
    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> modelBuilder)
        {
            modelBuilder.HasKey(e => e.IdLink)
                         .HasName("Pk_Link");

            modelBuilder.Property(e => e.Estado)
                .HasColumnName("estado")
                .HasMaxLength(10)
                .IsUnicode(false);

            modelBuilder.Property(e => e.Texto)
                .HasColumnName("texto")
                .HasMaxLength(50)
                .IsUnicode(false);

            modelBuilder.HasOne(d => d.IdAfiliadoNavigation)
                .WithMany(p => p.Link)
                .HasForeignKey(d => d.IdAfiliado)
                .HasConstraintName("Fk_Afiliado");

            modelBuilder.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.Link)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("Fk_Producto");
        }

        }
    }
