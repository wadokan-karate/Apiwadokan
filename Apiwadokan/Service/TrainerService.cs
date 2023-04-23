using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Service
{
    public class TrainerService : ITrainerService
    {
        private readonly ITrainerLogic _trainerLogic;
        public TrainerService(ITrainerLogic trainerLogic)
        {
            _trainerLogic = trainerLogic;
        }

        public async Task<int> InsertTrainerAsync(TrainerEntity trainerEntity)
        {
            await _trainerLogic.InsertTrainerAsync(trainerEntity);
            return trainerEntity.Id;
        }

        public async Task<List<TrainerEntity>> GetAllTrainersAsync()
        {
            return await _trainerLogic.GetAllTrainersAsync();
        }

        public async Task<TrainerEntity> GetTrainerByIdAsync(int id)
        {
            return await _trainerLogic.GetTrainerByIdAsync(id);
        }

        public async Task UpdateTrainerAsync(TrainerEntity trainerEntity)
        {
            await _trainerLogic.UpdateTrainerAsync(trainerEntity);
        }

        public async Task DeleteTrainerAsync(int id)
        {
            await _trainerLogic.DeleteTrainerAsync(id);
        }

    }
}
