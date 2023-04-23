using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class EventLogic : BaseContextLogic, IEventLogic
    {
        public EventLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public async Task UpdateEventAsync(EventEntity eventEntity)
        {
            _serviceContext.Events.Update(eventEntity);
            await _serviceContext.SaveChangesAsync();
        }

        public async Task<int> InsertEventAsync(EventEntity eventEntity)
        {
            _serviceContext.Set<EventEntity>().Add(eventEntity);
            await _serviceContext.SaveChangesAsync();
            return eventEntity.Id;
        }

        public async Task DeleteEventAsync(int id)
        {
            var eventToDelete = await _serviceContext.Set<EventEntity>()
                 .Where(u => u.Id == id).FirstAsync();

            eventToDelete.IsActive = false;

            await _serviceContext.SaveChangesAsync();
        }

        public async Task<List<EventEntity>> GetAllEventsAsync()
        {
            return await _serviceContext.Set<EventEntity>().ToListAsync();
        }

        public async Task<EventEntity> GetEventByIdAsync(int id)
        {
            return await _serviceContext.Set<EventEntity>()
                    .Where(u => u.Id == id).FirstOrDefaultAsync();
        }
    }
}
