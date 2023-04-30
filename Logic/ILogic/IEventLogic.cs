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
        Task<int> InsertEventAsync(EventEntity eventEntity);
        Task UpdateEventAsync(EventEntity eventEntity);
        Task DeleteEventAsync(int id);
        Task<List<EventEntity>> GetAllEventsAsync();
        Task<EventEntity> GetEventByIdAsync(int id);
    }
}
