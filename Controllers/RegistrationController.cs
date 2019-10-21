using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet("success")]
        public IActionResult Success(User userData)
        {
            return View(userData);
        }

        [HttpPost("register")]
        public IActionResult Register(IndexViewModel modelData)
        {

            User registrationData = modelData.UserRegistration;

            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", registrationData);
            }
            else
            {
                return View("../Home/Index");
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(IndexViewModel modelData)
        {

            UserLogin loginData = modelData.UserLogin;

            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", loginData);
            }
            else
            {
                return View("../Home/Index");
            }
        } 
    }
}