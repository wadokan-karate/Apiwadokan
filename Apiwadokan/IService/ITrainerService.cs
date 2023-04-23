using Entities.Entities;


namespace Apiwadokan.IService
{
    public interface ITrainerService
    {
        Task<int> InsertTrainerAsync(TrainerEntity trainerEntity);
        Task UpdateTrainerAsync(TrainerEntity trainerEntity);
        Task DeleteTrainerAsync(int id);
        Task<List<TrainerEntity>> GetAllTrainersAsync();
        Task<TrainerEntity> GetTrainerByIdAsync(int id);
    }
}
