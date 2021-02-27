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
    public class CategoriaRepository : ICategoria
    {
        private readonly SistemaAfiliacionContext sistemaAfiliacion;

        public CategoriaRepository(SistemaAfiliacionContext sistemaAfiliacion)
        {
            this.sistemaAfiliacion = sistemaAfiliacion;
        }
        public async Task AddCategoria(Categoria categoria)
        {
            sistemaAfiliacion.Add(categoria);
            await sistemaAfiliacion.SaveChangesAsync();
        }

        public async Task<IEnumerable<Categoria>> GetCategoria()
        {

            var categorias = await sistemaAfiliacion.Categoria.ToListAsync();

            return categorias;
        }
    }
}
