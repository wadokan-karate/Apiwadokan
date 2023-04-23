using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class TrainerLogic : ITrainerLogic
    {
        private readonly ServiceContext _serviceContext;
        public TrainerLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public async Task UpdateTrainerAsync(TrainerEntity trainerEntity)
        {
            _serviceContext.Trainers.Update(trainerEntity);
            await _serviceContext.SaveChangesAsync();
        }

        public async Task<int> InsertTrainerAsync(TrainerEntity trainerEntity)
        {
            _serviceContext.Set<TrainerEntity>().Add(trainerEntity);
            await _serviceContext.SaveChangesAsync();
            return trainerEntity.Id;
        }

        public async Task DeleteTrainerAsync(int id)
        {
            var trainerToDelete = await _serviceContext.Set<TrainerEntity>()
                 .Where(u => u.Id == id).FirstAsync();

            trainerToDelete.IsActive = false;

            await _serviceContext.SaveChangesAsync();
        }

        public async Task<List<TrainerEntity>> GetAllTrainersAsync()
        {
            return await _serviceContext.Set<TrainerEntity>().ToListAsync();
        }

        public async Task<TrainerEntity> GetTrainerByIdAsync(int id)
        {
            return await _serviceContext.Set<TrainerEntity>()
                    .Where(u => u.Id == id).FirstAsync();
        }
    }
}
