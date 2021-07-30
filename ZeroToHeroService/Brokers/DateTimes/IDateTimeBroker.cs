using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroToHeroService.Brokers.DateTimes
{
    interface IDateTimeBroker
    {
        DateTimeOffset GetCurrentDateTime();
    }
}
