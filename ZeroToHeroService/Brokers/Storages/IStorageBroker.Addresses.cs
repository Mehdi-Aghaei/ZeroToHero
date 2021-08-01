using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroToHeroService.Models.Addresses;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Address> InsertAddressAsync(Address address);

        IQueryable<Address> SelectAllAddresses();

        ValueTask<Address> SelectAddressByIdAsync(Guid addressId);

        ValueTask<Address> UpdateAddressAsync(Address address);

        ValueTask<Address> DeleteAddressAsync(Address address);


    }
}
