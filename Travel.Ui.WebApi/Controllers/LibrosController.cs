using co.Travel.Application;
using co.Travel.Application.AppServices;
using co.Travel.Domain.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Ui.WebApi.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : Controller
    {
        private readonly IApplicationService<Libro> LibroService;

        public LibrosController(IApplicationService<Libro> libroService)
        {
            this.LibroService = libroService;
        }

        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Libro> GetAll()
        {
            var lstLibro = LibroService.GetAll();

            return lstLibro;
        }

        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public ActionResult<Libro> GetId(int id)
        {
            var Libro = LibroService.GetById(id);

            if (Libro == null)
            {
                return NotFound();
            }
            return Ok(Libro);
        }

        // POST api/<LibroController>
        [HttpPost]
        public void Post([FromBody] Libro value)
        {
            if (value != null)
                LibroService.Add(value);

        }


    }
}
