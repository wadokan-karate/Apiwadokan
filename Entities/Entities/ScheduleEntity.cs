using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ScheduleEntity
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public string TimeRange { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Age { get; set; }
        public string Belt { get; set; }
        public bool IsActive { get; set; }


    }
}
