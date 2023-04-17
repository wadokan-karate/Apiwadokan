using Apiwadokan.IService;
using Entities.Entities;
using Logic.ILogic;

namespace Apiwadokan.Service
{
    public class ResourceService : IResourceService
    {
        //private readonly IProductService _productService;
        private readonly IResourceLogic _resourceLogic;
        public ResourceService(IResourceLogic resourceLogic)
        {
            _resourceLogic = resourceLogic;

        }

        public void DeleteResourceById(int id)
        {
            _resourceLogic.DeleteResourceById(id);
        }

        public List<ResourceEntity> GetResource()
        {
            return _resourceLogic.GetResource();
        }

        public List<ResourceEntity> GetAllResources()
        {
            return _resourceLogic.GetAllResources();
        }
        public int InsertResource(ResourceEntity product)
        {
            _resourceLogic.InsertResource(product);
            return product.Id;
        }

        public int PatchResource(ResourceEntity product)
        {
            _resourceLogic.PatchResource(product);
            return product.Id;
        }
    }


}


