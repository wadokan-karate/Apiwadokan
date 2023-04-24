using Apiwadokan.IService;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.ModelBinding;
using System.Web.Http.Cors;


namespace Apiwadokan.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    //[Route("[controller]/[action]")]
    public class ResourceController : ControllerBase
    {
        private readonly ILogger<ResourceController> _logger;
        private readonly IResourceService _resourceService;
        public ResourceController(ILogger<ResourceController> logger, IResourceService resourceService)
        {
            _logger = logger;
            _resourceService = resourceService;
        }

        [HttpPost(Name = "InsertResource")]
        public int Post([FromBody] ResourceEntity resourceEntity)
        {

            return _resourceService.InsertResource(resourceEntity);

        }

        [HttpGet(Name = "GetAllResource")]
        public List<ResourceEntity> GetAllResources()
        {
            return _resourceService.GetAllResources();

        }

        //[HttpGet(Name = "GetResourceById")]
        //public ResourceEntity GetTResourceById(int id)

        //{
        //    return _resourceService.GetResourceById(id);

        //}

        [HttpPatch(Name = "UpdateResource")]
        public void PatchResource([FromBody] ResourceEntity product)
        {

            _resourceService.PatchResource(product);

        }

        [HttpDelete(Name = "DeleteResource")]
        public void  DeleteResourceById([FromQuery] int id)
        {
            _resourceService.DeleteResourceById(id);

        }
    }
}
        
    
