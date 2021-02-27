using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Afiliados.Core.entities
{
    public partial class Afiliado
    {
        public Afiliado()
        {
            Link = new HashSet<Link>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }

        public virtual ICollection<Link> Link { get; set; }
    }
}
