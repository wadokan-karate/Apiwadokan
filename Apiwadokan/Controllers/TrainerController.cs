using Apiwadokan.Attributes;
using Apiwadokan.IService;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("[controller]/[action]")]
    public class TrainerController : ControllerBase
    {
        private readonly ITrainerService _trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "InsertTrainer")]
        public async Task<int> InsertTrainer([FromBody] TrainerEntity trainerEntity)
        {
            return await _trainerService.InsertTrainerAsync(trainerEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllTrainers")]
        public async Task<List<TrainerEntity>> GetAllTrainers()
        {
            return await _trainerService.GetAllTrainersAsync();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetTrainerById")]
        public async Task<TrainerEntity> GetTrainerById(int id)
        {
            return await _trainerService.GetTrainerByIdAsync(id);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "UpdateTrainer")]
        public async Task UpdateTrainer([FromBody] TrainerEntity trainerEntity)
        {
            await _trainerService.UpdateTrainerAsync(trainerEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name = "DeleteTrainer")]
        public async Task DeleteTrainer([FromQuery] int id)
        {
            await _trainerService.DeleteTrainerAsync(id);
        }
    }
}