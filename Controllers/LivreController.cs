using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Controllers
{
    public class LivreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
