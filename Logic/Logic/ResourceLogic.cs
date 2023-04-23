using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ResourceLogic : BaseContextLogic, IResourceLogic
    {
        public ResourceLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public async Task UpdateResourceAsync(ResourceEntity resourceEntity)
        {
            _serviceContext.Resources.Update(resourceEntity);
            await _serviceContext.SaveChangesAsync();
        }

        public async Task<int> InsertResourceAsync(ResourceEntity resourceEntity)
        {
            _serviceContext.Set<ResourceEntity>().Add(resourceEntity);
            await _serviceContext.SaveChangesAsync();
            return resourceEntity.Id;
        }

        public async Task DeleteResourceAsync(int id)
        {
            var resourceToDelete = await _serviceContext.Set<ResourceEntity>()
                .Where(u => u.Id == id).FirstAsync();

            resourceToDelete.IsActive = false;

            await _serviceContext.SaveChangesAsync();
        }

        public async Task<List<ResourceEntity>> GetAllResourcesAsync()
        {
            return await _serviceContext.Set<ResourceEntity>().ToListAsync();
        }

        public async Task<ResourceEntity> GetResourceByIdAsync(int id)
        {
            return await _serviceContext.Set<ResourceEntity>()
                .Where(u => u.Id == id).FirstAsync();
        }
    }
}


