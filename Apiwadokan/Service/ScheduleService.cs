using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Service
{

    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleLogic _scheduleLogic;
        public ScheduleService(IScheduleLogic scheduleLogic)
        {
            _scheduleLogic = scheduleLogic;
        }

        public async Task<int> InsertScheduleAsync(ScheduleEntity scheduleEntity)
        {
            await _scheduleLogic.InsertScheduleAsync(scheduleEntity);
            return scheduleEntity.Id;
        }

        public async Task<List<ScheduleEntity>> GetAllSchedulesAsync()
        {
            return await _scheduleLogic.GetAllSchedulesAsync();
        }

        public async Task<ScheduleEntity> GetScheduleByIdAsync(int id)
        {
            return await _scheduleLogic.GetScheduleByIdAsync(id);
        }

        public async Task UpdateScheduleAsync(ScheduleEntity scheduleEntity)
        {
            await _scheduleLogic.UpdateScheduleAsync(scheduleEntity);
        }

        public async Task DeleteScheduleAsync(int id)
        {
            await _scheduleLogic.DeleteScheduleAsync(id);
        }
    }
}
