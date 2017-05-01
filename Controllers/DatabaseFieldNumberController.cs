using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Voltron.Client.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseFieldNumberController
    {
        [HttpGet("[action]")]
        public int DBFinder(int id)
        {
            return 123;
        }

        [HttpPost("[action]")]
        public void DBFieldNumberRequest(){

        }
    }
}
