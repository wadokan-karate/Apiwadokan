using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface ITrainerLogic
    {
        Task<int> InsertTrainerAsync(TrainerEntity trainerEntity);
        Task UpdateTrainerAsync(TrainerEntity trainerEntity);
        Task DeleteTrainerAsync(int id);
        Task<List<TrainerEntity>> GetAllTrainersAsync();
        Task<TrainerEntity> GetTrainerByIdAsync(int id);
    }
}
