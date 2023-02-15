using EspetinhoDoClaudioShop.Models;
using EspetinhoDoClaudioShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EspetinhoDoClaudioShop.Controllers
{
    public class SkewerController : Controller
    {
        private readonly ISkewerRepository _skewerRepository;
        private readonly ICategoryRepository  _categoryRepository;

        public SkewerController
            (ISkewerRepository skewerRepository, ICategoryRepository categoryRepository)
        {
            _skewerRepository = skewerRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Espetinhos";
            //return View(_skewerRepository.AllSkewers);

            SkewerListViewModel skewerListViewModel = new SkewerListViewModel
                (_skewerRepository.AllSkewers, "Espetinhos");
            return View(skewerListViewModel);
        }
    }
}
