using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeroToHeroService.Models.CustomerAddresses;

namespace ZeroToHeroService.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void AddCustomerAddressReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>()
                .HasKey(customerAddress =>
                    new { customerAddress.CustomerId, customerAddress.AddressId });

            modelBuilder.Entity<CustomerAddress>()
                .HasOne(customerAddress => customerAddress.Address)
                .WithMany(address => address.CustomerAddresses)
                .HasForeignKey(customerAddress => customerAddress.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CustomerAddress>()
                .HasOne(customerAddress => customerAddress.Customer)
                .WithMany(customer => customer.CustomerAddresses)
                .HasForeignKey(customerAddress => customerAddress.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
