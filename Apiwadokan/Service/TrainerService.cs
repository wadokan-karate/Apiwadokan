using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace Apiwadokan.Service
{

    public class TrainerService : ITrainerService
    {
        private readonly ITrainerLogic _trainerLogic;
        public TrainerService(ITrainerLogic trainerLogic)
        {
            _trainerLogic = trainerLogic;
        }

        public int InsertTrainer(TrainerEntity trainerEntity)
        {
            _trainerLogic.InsertTrainer(trainerEntity);
            return trainerEntity.Id;
        }

        public List<TrainerEntity> GetAllTrainers()
        {
            return _trainerLogic.GetAllTrainers();
        }

        public TrainerEntity GetTrainerById(int id)
        {
            return _trainerLogic.GetTrainerById(id);
        }

        public void UpdateTrainer(TrainerEntity trainerEntity)
        {
            _trainerLogic.UpdateTrainer(trainerEntity);
        }

        public void DeleteTrainer(int id)
        {
            _trainerLogic.DeleteTrainer(id);
        }
    }
}
