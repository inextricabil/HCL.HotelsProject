using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HCL.HackatonHotels.Controllers;

namespace HCL.HackatonHotels.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : HackatonHotelsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
