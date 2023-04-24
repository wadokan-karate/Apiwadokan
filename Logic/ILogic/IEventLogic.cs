using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEventLogic
    {
        void DeleteEventById(int Id);
        List<EventEntity> GetEvent();
        List<EventEntity> GetAllEvents();
        void InsertEvent(EventEntity eventEntity);
        void PatchEvent(EventEntity product);
    }
}
