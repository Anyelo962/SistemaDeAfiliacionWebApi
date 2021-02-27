using Afiliados.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Afiliados.Core.Interfaces
{
   public interface ILink
    {
        Task<IEnumerable<Link>> GetLink();
        Task AddLink(Link link);

    }
}
