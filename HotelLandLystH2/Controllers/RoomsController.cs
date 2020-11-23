using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelLandLystH2.Controllers
{
    public class RoomsController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            //Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

    }
}
