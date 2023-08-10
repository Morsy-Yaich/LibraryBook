using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Controllers
{
    public class SectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
