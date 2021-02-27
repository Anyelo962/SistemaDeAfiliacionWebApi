using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Afiliados.Core.entities
{
    public partial class Link
    {
        public int IdLink { get; set; }
        public int? IdAfiliado { get; set; }
        public int? IdProducto { get; set; }
        public string Estado { get; set; }
        public string Texto { get; set; }

        public virtual Afiliado IdAfiliadoNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
