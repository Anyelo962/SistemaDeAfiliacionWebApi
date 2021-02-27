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
    public class AfiliadosRepository : IAfiliados
    {
        private readonly SistemaAfiliacionContext sistemaAfiliacion;

        public AfiliadosRepository(SistemaAfiliacionContext sistemaAfiliacion)
        {
            this.sistemaAfiliacion = sistemaAfiliacion;
        }
        public async Task AddAfiliado(Afiliado afiliado)
        {
            sistemaAfiliacion.Add(afiliado);

            await sistemaAfiliacion.SaveChangesAsync();

        }

        public async Task<IEnumerable<Afiliado>> GetAfiliados()
        {
            var afiliados = await sistemaAfiliacion.Afiliado.ToListAsync();
            return afiliados;
        }
    }
}
