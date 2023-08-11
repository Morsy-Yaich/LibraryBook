using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;
using LibraryBook.Models;


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
            Section<Theme> themes = _repositoryTheme.GetAll();
            return View();
        }
    }
}
