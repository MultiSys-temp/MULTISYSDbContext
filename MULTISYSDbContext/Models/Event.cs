using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTISYSDbContext.Models
{
    [Table("Event")]
    public class Event
    {
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string eventnDesc { get; set; }
        public DateTime eventDate { get; set; }
    }
}