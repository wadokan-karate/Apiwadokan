using Apiwadokan.IService;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace Apiwadokan.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class ScheduleController : ControllerBase
    {
        private readonly ILogger<ScheduleController> _logger;
        private readonly IScheduleService _scheduleService;
        public ScheduleController(ILogger<ScheduleController> logger, IScheduleService scheduleService)
        {
            _logger = logger;
            _scheduleService = scheduleService;
        }

        [HttpPost(Name = "InsertSchedule")]
        public int Post([FromBody] ScheduleEntity scheduleEntity)
        {

            return _scheduleService.InsertSchedule(scheduleEntity);

        }

        [HttpGet(Name = "GetAllSchedules")]
        public List<ScheduleEntity> GetAllSchedules()
        {
            return _scheduleService.GetAllSchedules();

        }

        [HttpGet(Name = "GetScheduleById")]
        public ScheduleEntity GetScheduleById(int id)

        {
            return _scheduleService.GetScheduleById(id);

        }

        [HttpPatch(Name = "UpdateSchedule")]
        public void UpdateSchedule([FromBody] ScheduleEntity scheduleEntity)
        {

            _scheduleService.UpdateSchedule(scheduleEntity);

        }

        [HttpDelete(Name = "DeleteSchedule")]
        public void DeleteSchedule([FromQuery] int id)
        {
            _scheduleService.DeleteSchedule(id);

        }
    }
}
