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
    public class AutoresController : Controller
    {
        private readonly IApplicationService<Autor>  AutorServ;

        public AutoresController(IApplicationService<Autor> autorServ)
        {
            this.AutorServ = autorServ;
        }

        // GET: api/<AutoresController>
        [HttpGet]
        public IEnumerable<Autor> GetAll()
        {
            var lstAutores = AutorServ.GetAll();

            return lstAutores;
        }

        // GET api/<AutoresController>/5
        [HttpGet("{id}")]
        public ActionResult<Autor> GetId(int id)
        {
            var Autor = AutorServ.GetById(id);

            if (Autor == null)
            {
                return NotFound();
            }
            return Ok(Autor);
        }

        // POST api/<AutoresController>
        [HttpPost]
        public void Post([FromBody] Autor value)
        {
            if (value != null)
                AutorServ.Add(value);
        }
    }
}
