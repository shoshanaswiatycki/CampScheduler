using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LocationTImeUnavailability
    {
        public LocationTImeUnavailability() { }
        public int Id { get; set; }
        public int LocationId { get; set; }
        public TimeOnly TimeFrom { get; set; }
        public TimeOnly TimeUntil { get; set; }
    }
}
