using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCL.HackatonHotels.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HCL.HackatonHotels.Web.Mvc.Controllers
{
    public class RoomsController : HackatonHotelsControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}