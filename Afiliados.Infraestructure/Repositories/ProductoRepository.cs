using Afiliados.Core.entities;
using Afiliados.Core.Interfaces;
using Afiliados.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Afiliados.Infraestructure.Repositories
{
    public class ProductoRepository : IProductos
    {
        private readonly SistemaAfiliacionContext sistemaAfiliacion;

        public ProductoRepository(SistemaAfiliacionContext sistemaAfiliacion)
        {
            this.sistemaAfiliacion = sistemaAfiliacion;
        }
        public async Task AddProducto(Productos productos)
        {
            sistemaAfiliacion.Add(productos);
            await sistemaAfiliacion.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Productos>> GetProductos()
        {
            var productos = await sistemaAfiliacion.Productos.ToListAsync();

            return productos;
        }
    }
}
