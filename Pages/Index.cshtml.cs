using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesExample1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string FirstName { get; set; }

        [BindProperty(SupportsGet = true)] //you have to pass this value in url like ?LastName=Ali
        public string LastName { get; set; }

        public void OnGet()
        {
            //writing the name to the UI
            FirstName = "Muzdalifa";

            if (string.IsNullOrEmpty(LastName))
                LastName = "User";
        }
    }
}
