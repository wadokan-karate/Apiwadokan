using Entities.Entities;

namespace Apiwadokan.IService
{
    public interface IResourceService
    {
        void DeleteResourceById(int id);
        List<ResourceEntity> GetResource();
        List<ResourceEntity> GetAllResources();
        int InsertResource(ResourceEntity resourceEntity);
        int PatchResource(ResourceEntity resourceEntity);
    }
}
