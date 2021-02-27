using Afiliados.Core.entities;
using Afiliados.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace afiliados.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoria categoria;

        public CategoriaController(ICategoria categoria)
        {
            this.categoria = categoria;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategoria()
        {

            var categoria = await this.categoria.GetCategoria();

            return base.Ok(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> AddAfiliados(Categoria categorias)
        {
            var addCategoria = new Categoria
            {
                Nombre = categorias.Nombre,
                Productos = categorias.Productos
            };
            await categoria.AddCategoria(addCategoria);
            return Ok();
        }
    }
}
