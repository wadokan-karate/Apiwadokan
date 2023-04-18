using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace Apiwadokan.Service
{

    public class ScheduleService: IScheduleService
    {
        private readonly IScheduleLogic _scheduleLogic;
        public ScheduleService(IScheduleLogic scheduleLogic)
        {
            _scheduleLogic = scheduleLogic;
        }
 
        public int InsertSchedule(ScheduleEntity scheduleEntity)
        {
            _scheduleLogic.InsertSchedule(scheduleEntity);
            return scheduleEntity.Id;
        }

        public List<ScheduleEntity> GetAllSchedules()
        {
            return _scheduleLogic.GetAllSchedules();
        }

        public ScheduleEntity GetScheduleById(int id)
        {
            return _scheduleLogic.GetScheduleById(id);
        }

        public void UpdateSchedule(ScheduleEntity scheduleEntity)
        {
           _scheduleLogic.UpdateSchedule(scheduleEntity);
        }

        public void DeleteSchedule(int id)
        {
            _scheduleLogic.DeleteSchedule(id);
        }
    }
}
