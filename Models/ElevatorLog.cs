using System;

namespace elevator_control_system.Models
{

    // holds the log data
    public class ElevatorLog
    {
        public int LogsId { get; set; }  // accessors used in properties to define how values are accessed/assigned

        public DateTime Date { get; set; }

        public TimeSpan RequestedAt { get; set; }

        public string Action { get; set; }
    }
}
