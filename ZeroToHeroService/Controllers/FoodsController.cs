using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models;
using ZeroToHeroService.Services;

namespace ZeroToHeroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodsController : ControllerBase
    {
    
        private readonly ILogger<FoodsController> _logger;
        private readonly IFoodService _foodService;

        public FoodsController(ILogger<FoodsController> logger,IFoodService foodService)
        {
            _foodService = foodService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Food> Get()
        {
            throw new NotImplementedException();
        }
    }
}
