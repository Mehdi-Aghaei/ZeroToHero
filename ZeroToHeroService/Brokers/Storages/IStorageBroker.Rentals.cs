using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Rentals;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Rental> InsertRentalAsync(Rental rental);
        IQueryable<Rental> SelectAllRentals();
        ValueTask<Rental> SelectRentalByIdAsync(Guid rentalId);
        ValueTask<Rental> UpdateRentalAsync(Rental rental);
        ValueTask<Rental> DeleteRentalAsync(Rental rental);

    }
}
