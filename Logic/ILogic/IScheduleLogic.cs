using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IScheduleLogic
    {
        Task<int> InsertScheduleAsync(ScheduleEntity scheduleEntity);
        Task UpdateScheduleAsync(ScheduleEntity scheduleEntity);
        Task DeleteScheduleAsync(int id);
        Task<List<ScheduleEntity>> GetAllSchedulesAsync();
        Task<ScheduleEntity> GetScheduleByIdAsync(int id);
    
    }
}
