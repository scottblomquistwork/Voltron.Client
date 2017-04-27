using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Voltron.Client.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseFieldNumberGenerator
    {
        [HttpGet("[action]")]
        public int DBFinder()
        {
            return 123;
        }
    }
}
