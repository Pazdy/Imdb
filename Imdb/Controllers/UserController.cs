using Microsoft.AspNetCore.Mvc;

namespace imdb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
