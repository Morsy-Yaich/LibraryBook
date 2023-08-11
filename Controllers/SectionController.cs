using LibraryBook.Repository;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
