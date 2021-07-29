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
    public class FoodController : ControllerBase
    {
    
        private readonly ILogger<FoodController> _logger;
        private readonly IFoodService _foodService;

        public FoodController(ILogger<FoodController> logger,IFoodService foodService)
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
