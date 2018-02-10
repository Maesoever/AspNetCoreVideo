using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("company/[Controller]/[action]")]
    public class EmployeeController : Controller
    {

        public ContentResult Name()
        {
            return Content("Dickiedick");
        }


        public string Country()
        {
            return "The Netherlands";
        }


        public string Index()
        {
            return "Hello from Employee controller";
        }
    }
}
