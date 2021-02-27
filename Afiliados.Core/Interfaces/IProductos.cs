using Afiliados.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Afiliados.Core.Interfaces
{
   public interface IProductos
    {
        Task<IEnumerable<Productos>> GetProductos();
        Task AddProducto(Productos productos);
    }
}
