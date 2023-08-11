using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;
using LibraryBook.Models;


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
            List<Auteur> auteurs = _repositoryAuteur.GetAll();
            return View(auteurs);
        }
    }
}
