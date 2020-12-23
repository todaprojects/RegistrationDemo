using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RegistrationDemoRazorPages.Models;

namespace RegistrationDemoRazorPages.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly ILogger<RegistrationModel> _logger;

        [BindProperty] public RegistrationForm RegistrationForm { get; set; }

        public RegistrationModel(ILogger<RegistrationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid) return;
            RegistrationForm.Name = null;
            RegistrationForm.Age = null;
            RegistrationForm.Email = null;
        }
    }
}