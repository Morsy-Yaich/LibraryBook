using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Controllers
{
    public class LivreController : Controller
    {
        private readonly IRepositoryLivre _repositoryLivre;
        public LivreController(IRepositoryLivre repositoryLivre)
        {
            _repositoryLivre = repositoryLivre;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
