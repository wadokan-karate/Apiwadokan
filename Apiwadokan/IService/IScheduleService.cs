using Entities.Entities;


namespace Apiwadokan.IService
{
    public interface IScheduleService
    {
        int InsertSchedule(ScheduleEntity scheduleEntity);
        void UpdateSchedule(ScheduleEntity scheduleEntity);
        void DeleteSchedule(int id);
        List<ScheduleEntity> GetAllSchedules();
        ScheduleEntity GetScheduleById(int id);
    }
}
