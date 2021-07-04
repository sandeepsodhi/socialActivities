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

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }
        
        [HttpGet("{id}")] //activities/ids
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            //return await _context.Activities.FindAsync(id);
            return Ok();
        }
    }
}