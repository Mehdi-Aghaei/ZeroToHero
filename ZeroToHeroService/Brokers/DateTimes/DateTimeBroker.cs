using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroToHeroService.Brokers.DateTimes
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime() => DateTimeOffset.UtcNow;
      
    }
}
