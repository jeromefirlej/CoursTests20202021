using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Minify.Controllers
{
    [Controller]
    [Route("/redirect")]
    public class RedirectController : ControllerBase
    {
        [HttpGet]
        [Route("/redirect/{id}")]
        public IActionResult Get(string id)
        {
            return Redirect("https://www.google.com");
        }
    }
}