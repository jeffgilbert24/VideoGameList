using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoGameList.Models;

namespace VideoGameList.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }
   
    }
}
