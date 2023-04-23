using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using System.Threading.Tasks;

namespace Apiwadokan.Service
{
    public class ResourceService : IResourceService
    {
        private readonly IResourceLogic _resourceLogic;
        public ResourceService(IResourceLogic resourceLogic)
        {
            _resourceLogic = resourceLogic;
        }

        public async Task<int> InsertResourceAsync(ResourceEntity resourceEntity)
        {
            await _resourceLogic.InsertResourceAsync(resourceEntity);
            return resourceEntity.Id;
        }

        public async Task<List<ResourceEntity>> GetAllResourcesAsync()
        {
            return await _resourceLogic.GetAllResourcesAsync();
        }

        public async Task<ResourceEntity> GetResourceByIdAsync(int id)
        {
            return await _resourceLogic.GetResourceByIdAsync(id);
        }

        public async Task UpdateResourceAsync(ResourceEntity resourceEntity)
        {
            await _resourceLogic.UpdateResourceAsync(resourceEntity);
        }

        public async Task DeleteResourceAsync(int id)
        {
            await _resourceLogic.DeleteResourceAsync(id);
        }

    }
}