using Microsoft.AspNetCore.Mvc;

namespace Travel.Ui.WebApi.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
