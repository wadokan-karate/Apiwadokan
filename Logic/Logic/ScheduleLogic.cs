using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ScheduleLogic : IScheduleLogic
    {
        private readonly ServiceContext _serviceContext;
        public ScheduleLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public async Task UpdateScheduleAsync(ScheduleEntity scheduleEntity)
        {
            _serviceContext.Schedules.Update(scheduleEntity);
            await _serviceContext.SaveChangesAsync();
        }

        public async Task<int> InsertScheduleAsync(ScheduleEntity scheduleEntity)
        {
            _serviceContext.Set<ScheduleEntity>().Add(scheduleEntity);
            await _serviceContext.SaveChangesAsync();
            return scheduleEntity.Id;
        }

        public async Task DeleteScheduleAsync(int id)
        {
            var scheduleToDelete = await _serviceContext.Set<ScheduleEntity>()
                 .Where(u => u.Id == id).FirstAsync();

            scheduleToDelete.IsActive = false;

            await _serviceContext.SaveChangesAsync();
        }

        public async Task<List<ScheduleEntity>> GetAllSchedulesAsync()
        {
            return await _serviceContext.Set<ScheduleEntity>().ToListAsync();
        }

        public async Task<ScheduleEntity> GetScheduleByIdAsync(int id)
        {
            return await _serviceContext.Set<ScheduleEntity>()
                    .Where(u => u.Id == id).FirstOrDefaultAsync();
        }

    }
}
