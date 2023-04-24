using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class EventLogic : BaseContextLogic, IEventLogic
    {
        public EventLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void DeleteEventById(int Id)
        {
            var chooseEvent = _serviceContext.Set<EventEntity>().Where(p => p.Id == Id).First();
            _serviceContext.Events.Remove(chooseEvent);
            _serviceContext.SaveChanges();
        }

        public void InsertEvent(EventEntity eventEntity)
        {
            _serviceContext.Events.Add(eventEntity);
            _serviceContext.SaveChanges();
        }

        public void PatchEvent(EventEntity product)
        {
            _serviceContext.Events.Update(product);
            _serviceContext.SaveChanges();
        }

        public List<EventEntity> GetEvent()
        {
            return _serviceContext.Set<EventEntity>().ToList();

        }
        public List<EventEntity> GetAllEvents()
        {
            return _serviceContext.Set<EventEntity>().ToList();

        }

       
    }
}
