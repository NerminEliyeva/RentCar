using Microsoft.AspNetCore.Mvc;
using RentCar.Models.Models;
using RentCar.Services.Interfaces;
using System.Collections.Generic;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRentCarService _rentCarService;
        public HomeController(IRentCarService rentCarService)
        {
            _rentCarService = rentCarService;
        }

        /// <summary>
        /// sehife acilan kimi isleyecek metod 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        #region Kartlar ve filterler


        /// <summary>
        /// masinlari ve filteri gosteren sehife
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CarsCardAndFilter()
        {
            return View(_rentCarService.GetCardsAndFilterInfo());
        }

        [HttpGet]
        public IActionResult CarDetails(int id)
        {
            return View(_rentCarService.GetCarDetails(id));
        }

        #endregion

        #region Yeni Masin ve Secim elave etmek
        [HttpGet]
        public IActionResult AddCar()
        {
            var result = _rentCarService.GetDataForAddingNewCar();
            return View(result);
        }

        [HttpPost]
        public IActionResult SaveNewCar([FromForm] SaveNewCarModel model)
        {
            var result = _rentCarService.SaveNewCarService(model);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult AddOption()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewMark()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveNewMark(string markName)
        {
            var result = _rentCarService.SaveNewMarkService(markName);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult AddNewModel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddNewEngineType()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();
        }

        #endregion
        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetModels(int id)
        {
            var result = _rentCarService.GetModels(id);
            return Ok(result);
        }

    }
}
