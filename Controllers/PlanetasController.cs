using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProximityCR_API.Models;
using ProximityCR_API.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProximityCR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetasController : ControllerBase
    {
        // GET: api/<PlanetasController>
        [HttpGet]
        public IActionResult Get()
        {
            RepoPlanetas repo = new RepoPlanetas();
            return Ok(repo.ObtenerPlanetas());
        }

        // GET api/<PlanetasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RepoPlanetas repo = new RepoPlanetas();

            var pla = repo.ObtenerPlaneta(id);

            if (pla == null)
            {
                var nf = NotFound("El planeta " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(pla);
        }

        // POST api/<PlanetasController>
        [HttpPost("agregar")]
        public IActionResult AgregarPlaneta(Planetas p)
        {
            RepoPlanetas repo = new RepoPlanetas();

            repo.Agregar(p);

            return CreatedAtAction(nameof(AgregarPlaneta), p);
        }

    }
}
