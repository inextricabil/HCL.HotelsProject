using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HCL.HackatonHotels.Controllers;

namespace HCL.HackatonHotels.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HackatonHotelsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
