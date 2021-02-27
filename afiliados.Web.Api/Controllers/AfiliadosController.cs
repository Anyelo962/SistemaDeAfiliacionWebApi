using Afiliados.Core.entities;
using Afiliados.Core.Interfaces;
using Afiliados.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace afiliados.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AfiliadosController : ControllerBase
    {
        private readonly IAfiliados afiliados;

        public AfiliadosController(IAfiliados afiliados)
        {
            this.afiliados = afiliados;
        }

        [HttpGet]
        public async Task<IActionResult> GetAfiliados()
        {

            var afiliado = await afiliados.GetAfiliados();

            return Ok(afiliado);
        }

        [HttpPost]
        public async Task<IActionResult> AddAfiliados( Afiliado afiliado)
        {
            var addAfiliado = new Afiliado
            {
                Nombre = afiliado.Nombre,
                Apellido = afiliado.Apellido,
                Sexo = afiliado.Sexo
            };

            await afiliados.AddAfiliado(addAfiliado);

            return Ok();
        }
    }
}
