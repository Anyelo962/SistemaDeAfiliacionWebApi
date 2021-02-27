using Afiliados.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Afiliados.Core.Interfaces
{
    public interface ICategoria
    {
        Task<IEnumerable<Categoria>> GetCategoria();
        Task AddCategoria(Categoria categoria);
    }
}
