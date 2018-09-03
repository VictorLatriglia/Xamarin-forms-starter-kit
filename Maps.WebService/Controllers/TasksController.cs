using Maps.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Maps.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [Route("Steps")]
        [ProducesResponseType(typeof(IEnumerable<TaskStep>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            List<TaskStep> steps = new List<TaskStep>
            {
                new TaskStep
                {
                    Title="This item isn't on the app",
                    Description = "We made this to show you how to call an API service",
                    IsCompleted = true
                },
                new TaskStep
                {
                    Title="This item isn't on the app either",
                    Description = "We made this to show you how to call an API service",
                    IsCompleted = true
                },
                new TaskStep
                {
                    Title="Gess where this item came from",
                    Description = "We made this to show you how to call an API service",
                    IsCompleted = true
                },
            };
            return Ok();
        }
    }
}