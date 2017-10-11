using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rps.Library;

namespace Rps.Web.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string PlayerName { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            var game = new RpsLogic();
            return Page();
        }
    }
}
