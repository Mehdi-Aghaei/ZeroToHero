using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ZeroToHeroService.Models.Bikes;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Bike> Bikes { get; set; }

        public async ValueTask<Bike> InsertBikeAsync(Bike bike)
        {
            EntityEntry<Bike> bikeEntityEntry = await this.Bikes.AddAsync(bike);
            await this.SaveChangesAsync();

            return bikeEntityEntry.Entity;
        }


        public IQueryable<Bike> SelectAllBikes() => this.Bikes.AsQueryable();


        public async ValueTask<Bike> SelectBikeByIdAsync(Guid bikeId)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await this.Bikes.FindAsync(bikeId);
        }

        public async ValueTask<Bike> UpdateBikeAsync(Bike bike)
        {
            EntityEntry<Bike> bikeEntityEntry = this.Bikes.Update(bike);
            await this.SaveChangesAsync();

            return bikeEntityEntry.Entity;

        }

        public async ValueTask<Bike> DeleteBikeAsync(Bike bike)
        {
            EntityEntry<Bike> bikeEntityEntry = this.Bikes.Remove(bike);
            await this.SaveChangesAsync();

            return bikeEntityEntry.Entity;

        }
    }
}
