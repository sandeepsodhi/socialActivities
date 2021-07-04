using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IMediator _mediator;

        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _mediator.Send(new List.Query());
        }
        
        [HttpGet("{id}")] //activities/ids
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            //return await _context.Activities.FindAsync(id);
            return Ok();
        }
    }
}