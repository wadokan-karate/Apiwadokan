using Entities;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.IService
{
    public interface IEventService
    {
        Task<int> InsertEventAsync(EventEntity eventEntity);
        Task UpdateEventAsync(EventEntity eventEntity);
        Task DeleteEventAsync(int id);
        Task<List<EventEntity>> GetAllEventsAsync();
        Task<EventEntity> GetEventByIdAsync(int id);
    }
}
