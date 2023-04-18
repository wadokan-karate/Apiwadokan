using Apiwadokan.IService;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace Apiwadokan.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class TrainerController : ControllerBase
    {
        private readonly ILogger<TrainerController> _logger;
        private readonly ITrainerService _trainerService;
        public TrainerController(ILogger<TrainerController> logger, ITrainerService trainerService)
        {
            _logger = logger;
            _trainerService = trainerService;
        }

        [HttpPost(Name = "InsertTrainer")]
        public int Post([FromBody] TrainerEntity scheduleEntity)
        {

            return _trainerService.InsertTrainer(scheduleEntity);

        }

        [HttpGet(Name = "GetAllTrainers")]
        public List<TrainerEntity> GetAllTrainers()
        {
            return _trainerService.GetAllTrainers();

        }

        [HttpGet(Name = "GetTrainerById")]
        public TrainerEntity GetTrainerById(int id)

        {
            return _trainerService.GetTrainerById(id);

        }

        [HttpPatch(Name = "UpdateTrainer")]
        public void UpdateTrainer([FromBody] TrainerEntity trainerEntity)
        {

            _trainerService.UpdateTrainer(trainerEntity);

        }

        [HttpDelete(Name = "DeleteTrainer")]
        public void DeleteTrainer([FromQuery] int id)
        {
            _trainerService.DeleteTrainer(id);

        }
    }
}
