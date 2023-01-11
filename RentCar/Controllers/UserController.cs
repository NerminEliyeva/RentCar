using Microsoft.AspNetCore.Mvc;

namespace RentCar.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult RegisterAndLogin()
        {
            return View();
        }

    }
}
