using Afiliados.Core.entities;
using Afiliados.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace afiliados.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductos productos;
        
        public ProductosController(IProductos productos)
        {
            this.productos = productos;
        }
        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {

            var producto = await productos.GetProductos();

            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductos(Productos product)
        {
            var addProducto = new Productos
            {
               IdCategoriaNavigation = product.IdCategoriaNavigation,
               Nombre = product.Nombre,
               Descripcion = product.Descripcion,
            };

            await productos.AddProducto(addProducto);


            return Ok();
        }
    }
}
