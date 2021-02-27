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
    public class LinkRepository : ILink
    {
        private readonly SistemaAfiliacionContext sistemaAfiliacion;

        public LinkRepository(SistemaAfiliacionContext sistemaAfiliacion)
        {
            this.sistemaAfiliacion = sistemaAfiliacion;
        }
        public async Task AddLink(Link link)
        {
            sistemaAfiliacion.Add(link);
            await sistemaAfiliacion.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Link>> GetLink()
        {
            var link = await sistemaAfiliacion.Link.ToListAsync();

            return link;

        }
    }
}
