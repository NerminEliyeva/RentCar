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

        [HttpGet]
        public IActionResult CarsCardAndFilter()
        {
            return View(_rentCarService.GetCardsAndFilterInfo());
        }
        [HttpPost]
        public IActionResult GetFilterData()
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
            var isOk = _rentCarService.SaveNewMarkService(markName);

            if (isOk)
            {
                return Ok(isOk);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult AddNewModel()
        {
            return View(_rentCarService.GetMarks());
        }

        [HttpPost]
        public IActionResult SaveNewModel(string modelName,int markId)
        {
            var isOk = _rentCarService.SaveNewModelService(modelName,markId);

            if (isOk)
            {
                return Ok(isOk);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult AddNewEngineType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveNewEngineType(string engineTypeName)
        {
            var isOk = _rentCarService.SaveNewEngineTypeService(engineTypeName);

            if (isOk)
            {
                return Ok(isOk);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveNewCategory(string categoryName)
        {
            var isOk = _rentCarService.SaveNewCategoryService(categoryName);

            if (isOk)
            {
                return Ok(isOk);
            }
            else
            {
                return BadRequest();
            }
        }

        #endregion
        [HttpGet]
        public IActionResult List()
        {
            var result = _rentCarService.GetListCarData();
            return View(result);
        }

        [HttpGet]
        public IActionResult GetModels(int id)
        {
            var result = _rentCarService.GetModels(id);
            return Ok(result);
        }

    }
}
