using Entities.Entities;


namespace Apiwadokan.IService
{
    public interface IScheduleService
    {
        Task <int> InsertScheduleAsync(ScheduleEntity scheduleEntity);
        Task UpdateScheduleAsync(ScheduleEntity scheduleEntity);
        Task DeleteScheduleAsync(int id);
        Task<List<ScheduleEntity>> GetAllSchedulesAsync();
        Task<ScheduleEntity> GetScheduleByIdAsync(int id);
    }
}
