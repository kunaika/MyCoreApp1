using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace MyCoreApp1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Correct Date Formatting
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

            // Assign to ViewData
            ViewData["TimeStamp"] = dateTime;
        }
    }

}
