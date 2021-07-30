using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ZeroToHeroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
     
        [HttpGet]
        public ActionResult<string> Get() =>
             Ok("Hi,You looking in wrong place!");
        
    }
}
