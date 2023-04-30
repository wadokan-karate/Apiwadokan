using Apiwadokan.IService;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Entities.Entities;
using System;
using Apiwadokan.Attributes;
using Microsoft.AspNetCore.Authorization;
using Apiwadokan.Service;
using Microsoft.AspNetCore.Cors;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Apiwadokan.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("[controller]/[action]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "InsertEvent")]
        public async Task<int> InsertEvent([FromBody] EventEntity eventEntity)
        {
            return await _eventService.InsertEventAsync(eventEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllEvents")]
        public async Task<List<EventEntity>> GetAllEvents()
        {
            return await _eventService.GetAllEventsAsync();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetEventById")]
        public async Task<EventEntity> GetEventById(int id)
        {
            return await _eventService.GetEventByIdAsync(id);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "UpdateEvent")]
        public async Task UpdateEvent([FromBody] EventEntity eventEntity)
        {
            await _eventService.UpdateEventAsync(eventEntity);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name = "DeleteEvent")]
        public async Task DeleteEvent([FromQuery] int id)
        {
            await _eventService.DeleteEventAsync(id);
        }
    }
}



