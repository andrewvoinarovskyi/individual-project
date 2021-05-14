using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DailyRent.Controllers
{
    [ApiController]
    [Route("")]
    public class DailyRentController : ControllerBase
    {
        private DailyRentService service;

        public DailyRentController(DailyRentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Post> GetAll()
        {
            return service.GetPosts();
        }
    }
}
