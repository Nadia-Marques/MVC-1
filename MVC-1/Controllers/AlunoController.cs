using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
