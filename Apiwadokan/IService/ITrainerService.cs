using Entities.Entities;


namespace Apiwadokan.IService
{
    public interface ITrainerService
    {
        int InsertTrainer(TrainerEntity trainerEntity);
        void UpdateTrainer(TrainerEntity trainerEntity);
        void DeleteTrainer(int id);
        List<TrainerEntity> GetAllTrainers();
        TrainerEntity GetTrainerById(int id);
    }
}
