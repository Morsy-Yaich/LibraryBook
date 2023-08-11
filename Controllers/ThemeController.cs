using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Controllers
{
    public class ThemeController : Controller
    {
        private readonly IRepositoryTheme _repositoryTheme;
        public ThemeController (IRepositoryTheme repositoryTheme)
        {
            _repositoryTheme = repositoryTheme;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
