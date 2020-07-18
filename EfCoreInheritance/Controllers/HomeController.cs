using System.Threading.Tasks;
using EfCoreInheritance.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreInheritance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISalesRepository _salesRepository;
        public HomeController(ISalesRepository salesRepository) { _salesRepository = salesRepository; }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Sale()
        {
            var sale = await _salesRepository.FindById(2);
            return Content("done");
        }
        
    }
}