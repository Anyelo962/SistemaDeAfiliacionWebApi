using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Afiliados.Core.entities
{
    public partial class Productos
    {
        public Productos()
        {
            Link = new HashSet<Link>();
        }

        public int Id { get; set; }
        public int? IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<Link> Link { get; set; }
    }
}
