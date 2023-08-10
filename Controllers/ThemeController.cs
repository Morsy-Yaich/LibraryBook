using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Controllers
{
    public class ThemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
