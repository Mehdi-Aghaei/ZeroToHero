using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;
using ZeroToHeroService.Models.Bikes;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Bike> InsertBikeAsync(Bike bike);
        IQueryable<Bike> SelectAllBikes();
        ValueTask<Bike> SelectBikeByIdAsync(Guid bikeId);
        ValueTask<Bike> UpdateBikeAsync(Bike bike);
        ValueTask<Bike> DeleteBikeAsync(Bike bike);
    }
}
