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
        int InsertTrainer(TrainerEntity trainerEntity);
        void UpdateTrainer(TrainerEntity trainerEntity);
        void DeleteTrainer(int id);
        List<TrainerEntity> GetAllTrainers();
        TrainerEntity GetTrainerById(int id);
    }
}
