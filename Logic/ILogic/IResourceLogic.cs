using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IResourceLogic
    {
        void DeleteResourceById(int Id);
        List<ResourceEntity> GetResource();
        List<ResourceEntity> GetAllResources();
        void InsertResource(ResourceEntity product);
       
        void PatchResource(ResourceEntity product);
    }
}
