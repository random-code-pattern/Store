using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RandomCodePattern.Store.Web.Controllers
{
    [Route("Store")]
    public class StoreController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}