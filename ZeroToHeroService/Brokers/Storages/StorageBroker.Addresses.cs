using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ZeroToHeroService.Models.Addresses;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Address> Addresses { get; set; }

        public async ValueTask<Address> InsertAddressAsync(Address address)
        {
            EntityEntry<Address> addressEntityEntry = await this.Addresses.AddAsync(address);
            await this.SaveChangesAsync();

            return addressEntityEntry.Entity;
        }

        public IQueryable<Address> SelectAllAddresses() => this.Addresses.AsQueryable();

        public async ValueTask<Address> SelectAddressByIdAsync(Guid addressId)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await Addresses.FindAsync(addressId);
        }

        public async ValueTask<Address> UpdateAddressAsync(Address address)
        {
            EntityEntry<Address> addressEntityEntry = this.Addresses.Update(address);
            await this.SaveChangesAsync();

            return addressEntityEntry.Entity;

        }

        public async ValueTask<Address> DeleteAddressAsync(Address address)
        {
            EntityEntry<Address> addressEntityEntry = this.Addresses.Remove(address);
            await this.SaveChangesAsync();

            return addressEntityEntry.Entity;
        }
    }
}
