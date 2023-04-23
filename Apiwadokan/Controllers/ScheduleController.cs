using Apiwadokan.Attributes;
using Apiwadokan.IService;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Apiwadokan.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("[controller]/[action]")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "InsertSchedule")]
        public async Task<int> InsertSchedule([FromBody] ScheduleEntity scheduleEntity)
        {
            return await _scheduleService.InsertScheduleAsync(scheduleEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllSchedules")]
        public async Task<List<ScheduleEntity>> GetAllSchedules()
        {
            return await _scheduleService.GetAllSchedulesAsync();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetScheduleById")]
        public async Task<ScheduleEntity> GetScheduleById(int id)
        {
            return await _scheduleService.GetScheduleByIdAsync(id);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "UpdateSchedule")]
        public async Task UpdateSchedule([FromBody] ScheduleEntity scheduleEntity)
        {
            await _scheduleService.UpdateScheduleAsync(scheduleEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name = "DeleteSchedule")]
        public async Task DeleteSchedule([FromQuery] int id)
        {
            await _scheduleService.DeleteScheduleAsync(id);
        }
    }
}
