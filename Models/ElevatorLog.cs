using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator_control_system.Models
{
    public class ElevatorLog
    {
        public int LogsId { get; set; }  // Primary key: logs_id

        public DateTime Date { get; set; }  // Date of the log

        public TimeSpan RequestedAt { get; set; }  // Time when the elevator was requested

        public string Action { get; set; } // Description of the action
    }
}
