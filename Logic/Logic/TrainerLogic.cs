using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;

namespace Logic.Logic
{
    public class TrainerLogic : ITrainerLogic
    {
        private readonly ServiceContext _serviceContext;
        public TrainerLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void UpdateTrainer(TrainerEntity trainerEntity)
        {
            _serviceContext.Trainers.Update(trainerEntity);
            _serviceContext.SaveChanges();
        }

        public int InsertTrainer(TrainerEntity trainerEntity)
        {
            _serviceContext.Set<TrainerEntity>().Add(trainerEntity);
            _serviceContext.SaveChanges();
            return trainerEntity.Id;
        }

        public void DeleteTrainer(int id)
        {
            var trainerToDelete = _serviceContext.Set<TrainerEntity>()
                 .Where(u => u.Id == id).First();

            trainerToDelete.IsActive = false;

            _serviceContext.SaveChangesAsync();
        }

        public List<TrainerEntity> GetAllTrainers()
        {
            return _serviceContext.Set<TrainerEntity>().ToList();
        }
        public TrainerEntity GetTrainerById(int id)
        {
            return _serviceContext.Set<TrainerEntity>()
                    .Where(u => u.Id == id).First();
        }

    }

}

