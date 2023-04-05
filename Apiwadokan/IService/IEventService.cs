using Entities;
using Entities.Entities;

namespace Apiwadokan.IService
{
    public interface IEventService
    {
        void DeleteEventById(int id);
        List<EventEntity> GetEvent ();
        List<EventEntity> GetAllEvents();
        int InsertEvent(EventEntity product);
        int PatchEvent(EventEntity product);
    }
}
