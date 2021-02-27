using System;
using Afiliados.Core.entities;
using Afiliados.Infraestructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Afiliados.Infraestructure.Data
{
    public partial class SistemaAfiliacionContext : DbContext
    {
        public SistemaAfiliacionContext()
        {
        }

        public SistemaAfiliacionContext(DbContextOptions<SistemaAfiliacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Afiliado> Afiliado { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Link> Link { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-0BP9LLN;Initial Catalog=SistemaAfiliacion;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AfiliadoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProductoConfiguration());
            modelBuilder.ApplyConfiguration(new LinkConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
