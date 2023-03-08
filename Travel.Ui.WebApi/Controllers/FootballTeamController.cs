using co.Travel.Application;
using co.Travel.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Ui.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        private readonly IApplicationService<FootballTeam> futbol;

        public FootballTeamController(IApplicationService<FootballTeam> _futbol)
        {
            futbol = _futbol;
        }

        [HttpGet]
        public ActionResult Get() {
            return Ok(new FootballTeam()
            {
                Name ="san lorenzo",
                score = 100
            });
        }
    }
}
