using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class EventEntity
    {
        public int Id { get; set; }
        public int IdPhotoFile { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
   
    
    
    
    
    //public class InChangeOrganizer
    //{ public int Id { get; set; }
    //public string Name { get; set; }
    //    public string Description { get; set; }

    //}
}
