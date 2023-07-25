using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ScheduleConstant
    {
        public ScheduleConstant() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int AgeGroupId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public TimeOnly MinStartTime { get; set; }
        public TimeOnly MaxEndTime { get; set; }
        public int LocationId { get; set; }
    }
}
