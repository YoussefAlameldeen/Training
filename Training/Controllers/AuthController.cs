using Microsoft.AspNetCore.Mvc;
using Training.Models;
using Training.Services;

namespace Training.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet] 
        public IActionResult Register()
        {
            return View();
        }                                                                                               


        [HttpPost]
        public IActionResult Register(ModelView modelView)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(modelView);
     

                return RedirectToAction("Index", "Home");
            }

            return View(modelView);
        }
    }
}

