using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Service
{
    public class EventService : IEventService
    {
        private readonly IEventLogic _eventLogic;
        public EventService(IEventLogic eventLogic)
        {
            _eventLogic = eventLogic;
        }

        //public async Task<int> InsertEventAsync(EventEntity eventEntity)
        //{
        //    await _eventLogic.InsertEventAsync(eventEntity);
        //    return eventEntity.Id;
        //}

        public async Task <int> InsertEventAsync(EventEntity eventEntity)
        {
            if (!ValidateModel(eventEntity))
            {
                throw new InvalidDataException();
            }
           await _eventLogic.InsertEventAsync(eventEntity);
            if (!ValidateInsertedEvent(eventEntity))

            {
                throw new InvalidOperationException();
            }
            return eventEntity.Id;


        }


        // Creamos una nueva clase y Validamos elementos de la clase EventEntitiy
        public static bool ValidateModel(EventEntity eventEntity)
        {

            if (eventEntity == null)
            {
                return false;
            }
            if (eventEntity.Image == null || eventEntity.Name == "")
            {
                return false; ;
            }
            if (eventEntity.Name == null || eventEntity.Name == "")
            {
                return false; ;
            }
            if (eventEntity.Description == null || eventEntity.Description == "")
            {
                return false; ;
            }
           
            return true;
        }

        public static bool ValidateInsertedEvent(EventEntity eventEntity)
        {
            if (!ValidateModel(eventEntity))

            {
                return false;
            }
            if (eventEntity.Id < 1)
            {
                return false;
            }
            return true;
        }


        public async Task<List<EventEntity>> GetAllEventsAsync()
        {
            return await _eventLogic.GetAllEventsAsync();
        }

        public async Task<EventEntity> GetEventByIdAsync(int id)
        {
            return await _eventLogic.GetEventByIdAsync(id);
        }

        public async Task UpdateEventAsync(EventEntity eventEntity)
        {
            await _eventLogic.UpdateEventAsync(eventEntity);
        }

        public async Task DeleteEventAsync(int id)
        {
            await _eventLogic.DeleteEventAsync(id);
        }
    }
}
