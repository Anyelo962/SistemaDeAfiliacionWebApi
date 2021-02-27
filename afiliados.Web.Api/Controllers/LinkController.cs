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
    public class LinkController : ControllerBase
    {
        private readonly ILink link;

        public LinkController(ILink link)
        {
            this.link = link;
        }
        [HttpGet]
        public async Task<IActionResult> GetLink()
        {

            var links = await link.GetLink();

            return Ok(links);
        }

        [HttpPost]
        public async Task<IActionResult> AddLink(Link links)
        {
            var uniqueURL = Convert.ToBase64String(Guid.NewGuid().
                            ToByteArray()).Substring(0, 8).Replace("/", "2");
            var url = "https://bookiesbeef.es/buy/";
            var addLinks = new Link
            {
                IdAfiliado = links.IdAfiliado,
                IdProducto = links.IdProducto,
                Estado = links.Estado,
                Texto = links.Texto + url + links.IdAfiliado + links.IdProducto+ uniqueURL
            };

            await link.AddLink(addLinks);

            return Ok();
        }
    }
}
