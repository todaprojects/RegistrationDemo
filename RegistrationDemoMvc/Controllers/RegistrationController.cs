using Microsoft.AspNetCore.Mvc;
using RegistrationDemoMvc.Models;

namespace RegistrationDemoMvc.Controllers
{
    public class RegistrationController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Name = null;
                model.Age = null;
                model.Email = null;
            }

            return View("Index", model);
        }
    }
}