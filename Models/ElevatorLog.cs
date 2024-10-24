using System;

namespace elevator_control_system.Models
{
    public class ElevatorLog
    {
        public int LogsId { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan RequestedAt { get; set; }

        public string Action { get; set; }
    }
}
