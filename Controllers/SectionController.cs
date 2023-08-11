using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;
using LibraryBook.Models;

namespace LibraryBook.Controllers
{
    public class SectionController : Controller
    {
        private readonly IRepositorySection _repositorySection;
        public SectionController (IRepositorySection repositorySection)
        {
            _repositorySection = repositorySection;
        }
        public IActionResult Index()
        {
            List<Section> sections = _repositorySection.GetAll();
            return View(sections);
        }
    }
}
