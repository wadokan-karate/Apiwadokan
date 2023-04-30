using Entities.Entities;

namespace Apiwadokan.IService
{
    public interface IResourceService
    {
        Task DeleteResourceAsync(int id);
        Task<ResourceEntity> GetResourceByIdAsync(int id);
        Task<List<ResourceEntity>> GetAllResourcesAsync();
        Task<int> InsertResourceAsync(ResourceEntity product);
        Task UpdateResourceAsync(ResourceEntity product);
    }
}
