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
        int InsertSchedule(ScheduleEntity scheduleEntity);
        void UpdateSchedule(ScheduleEntity scheduleEntity);
        void DeleteSchedule(int id);
        List<ScheduleEntity> GetAllSchedules();
        ScheduleEntity GetScheduleById(int id);
    
    }
}
