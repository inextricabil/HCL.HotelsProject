using System.Collections.Generic;

namespace HCL.HackatonHotels.Web.Models
{
    public class ResponseModel
    {
        public IList<string> result { get; set; }
        public string targetUrl { get; set; }
        private bool success { get; set; }
        private object error { get; set; }
        private object unAuthorizedRequest { get; set; }
        private object __abp { get; set; }
    }
}
