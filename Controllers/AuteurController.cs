using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Controllers
{
    public class AuteurController : Controller
    {
        private readonly IRepositoryAuteur _repositoryAuteur;
        public AuteurController(IRepositoryAuteur repositoryAuteur) 
        {
            _repositoryAuteur = repositoryAuteur;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
