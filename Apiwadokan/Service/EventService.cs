using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;

namespace Apiwadokan.Service
{
    public class EventService : IEventService
    {
        //private readonly IProductService _productService;
        private readonly IEventLogic _eventLogic;
        public EventService(IEventLogic eventLogic)
        {
            _eventLogic = eventLogic;

        }

        public void DeleteEventById(int id)
        {
            _eventLogic.DeleteEventById(id);
        }

        public List<EventEntity> GetEvent()
        {
            return _eventLogic.GetEvent();
        }
        public List<EventEntity> GetAllEvents()
        {
            return _eventLogic.GetAllEvents();
        }
        public int InsertEvent(EventEntity product)
        {
            _eventLogic.InsertEvent(product);
            return product.Id;
        }

        public int PatchEvent(EventEntity product)
        {
            _eventLogic.PatchEvent(product);
            return product.Id;
        }

        public void AddEvent(EventEntity newEvent)
        {
            throw new NotImplementedException();
        }
    }
    

    }

