using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;
using LibraryBook.Models;


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
            List<Livre>  livres= _repositoryLivre.GetAll();
            return View(livres);
        }
    }
}
