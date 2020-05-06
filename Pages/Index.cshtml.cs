using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_input.Pages
{
    public class IndexModel : PageModel
    {
        public string Greeting { get; set; }
        public void OnGet()
        {
            Greeting = "Hello from the backend";
        }
        public void OnPost()
        {

        }
    }
}
