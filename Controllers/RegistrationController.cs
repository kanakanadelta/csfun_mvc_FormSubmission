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
        public IActionResult Register(User userData)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", userData);
            }
            else
            {
                return View("../Home/Index");
            }
        }
    }
}