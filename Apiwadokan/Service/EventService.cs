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
        //public int InsertEvent(EventEntity product)
        //{
        //    _eventLogic.InsertEvent(product);
        //   return product.Id;
        //}

        public int PatchEvent(EventEntity product)
        {
            _eventLogic.PatchEvent(product);
            return product.Id;
        }


        public int InsertEvent(EventEntity eventEntity)
        {
            if (!ValidateModel(eventEntity))
            {
              throw new InvalidDataException();
            }
             _eventLogic.InsertEvent(eventEntity);
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
             if (eventEntity.IdPhotoFile < 1)
            {
                return false; ; 
            }
            if (eventEntity.Name  == null || eventEntity.Name == "")
            {
                return false; ;
            }
            if (eventEntity.Description == null || eventEntity.Description == "")
            {
                return false; ;
            }
            if (eventEntity.InsertDate> DateTime.Now)
            {
                return false; ;
            }
           return true;
    }

    public  static bool ValidateInsertedEvent(EventEntity eventEntity) 
        {
            if (!ValidateModel( eventEntity )) 

            {
             return false;
            }
            if (eventEntity.Id < 1)
            {
             return false;
            }
             return true;
        }
    
}

}



