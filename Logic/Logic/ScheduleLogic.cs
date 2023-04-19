using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;

namespace Logic.Logic
{
    public class ScheduleLogic : IScheduleLogic
    {
        private readonly ServiceContext _serviceContext;
        public ScheduleLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void UpdateSchedule(ScheduleEntity scheduleEntity)
        {
            _serviceContext.Schedules.Update(scheduleEntity);
            _serviceContext.SaveChanges();
        }

        public int InsertSchedule(ScheduleEntity scheduleEntity)
        {
            _serviceContext.Set<ScheduleEntity>().Add(scheduleEntity);
            _serviceContext.SaveChanges();
            return scheduleEntity.Id;
        }

        public void DeleteSchedule(int id)
        {
            var scheduleToDelete = _serviceContext.Set<ScheduleEntity>()
                 .Where(u => u.Id == id).First();

            scheduleToDelete.IsActive = false;

           _serviceContext.SaveChangesAsync();
        }

        public List<ScheduleEntity> GetAllSchedules()
        {
            return _serviceContext.Set<ScheduleEntity>().ToList();
        }
        public ScheduleEntity GetScheduleById(int id)
        {
            return _serviceContext.Set<ScheduleEntity>()
                    .Where(u => u.Id == id).First();
        }

    }

}

