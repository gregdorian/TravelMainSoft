using co.Travel.Application;
using co.Travel.Domain.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Ui.WebApi.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialController : Controller
    {
        private readonly IApplicationService<Editorial> EditorialService;

        public EditorialController(IApplicationService<Editorial> EditorialService)
        {
            this.EditorialService = EditorialService;
        }

        // GET: api/<EditorialController>
        [HttpGet]
        public IEnumerable<Editorial> GetAll()
        {
            var lstEditorial = EditorialService.GetAll();

            return lstEditorial;
        }

        // GET api/<EditorialController>/5
        [HttpGet("{id}")]
        public ActionResult<Editorial> GetId(int id)
        {
            var Editorial = EditorialService.GetById(id);

            if (Editorial == null)
            {
                return NotFound();
            }
            return Ok(Editorial);
        }

        // POST api/<EditorialController>
        [HttpPost]
        public void Post([FromBody] Editorial value)
        {
            if (value != null)
                EditorialService.Add(value);

        }
    }
}
