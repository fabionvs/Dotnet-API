using Microsoft.AspNetCore.Mvc;
using app.Data;
using app.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    [ApiController]
    [Route("/contratos")]
    public class ContratoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Contrato>>> Get([FromServices] DataContext context)
        {
            var contratos = await context.Contratos.ToListAsync();
            return contratos;

        } 

    }
}