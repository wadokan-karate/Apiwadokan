using Apiwadokan.Attributes;
using Apiwadokan.IService;
using Apiwadokan.Service;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Apiwadokan.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("[controller]/[action]")]
    public class ResourceController : ControllerBase
    {
        private readonly IResourceService _resourceService;
        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "InsertResource")]
        public async Task<int> InsertResource([FromBody] ResourceEntity resourceEntity)
        {
            return await _resourceService.InsertResourceAsync(resourceEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllResources")]
        public async Task<List<ResourceEntity>> GetAllResources()
        {
            return await _resourceService.GetAllResourcesAsync();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetResourceById")]
        public async Task<ResourceEntity> GetResourceById(int id)
        {
            return await _resourceService.GetResourceByIdAsync(id);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "UpdateResource")]
        public async Task UpdateResource([FromBody] ResourceEntity resourceEntity)
        {
            await _resourceService.UpdateResourceAsync(resourceEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name = "DeleteResource")]
        public async Task DeleteResource([FromQuery] int id)
        {
            await _resourceService.DeleteResourceAsync(id);
        }
    }
}
