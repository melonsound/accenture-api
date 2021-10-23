using acr_main_api.Data;
using acr_main_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acr_main_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private MainContext _ctx;

        public MainController(MainContext mainContext)
        {
            _ctx = mainContext;
        }

        [HttpGet("main-table")]
        public IActionResult GetDomains()
        {
            var query = _ctx.Domains
                .Include(q => q.Significatives)
                .ThenInclude(w => w.Percentages)
                .SingleOrDefault(x => x.Id == 3);

            return Ok(query);
        }
    }
}
