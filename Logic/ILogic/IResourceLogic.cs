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
        Task<int> InsertResourceAsync(ResourceEntity resourceEntity);
        Task UpdateResourceAsync(ResourceEntity resourceEntity);
        Task DeleteResourceAsync(int id);
        Task<List<ResourceEntity>> GetAllResourcesAsync();
        Task<ResourceEntity> GetResourceByIdAsync(int id);
    }
}
