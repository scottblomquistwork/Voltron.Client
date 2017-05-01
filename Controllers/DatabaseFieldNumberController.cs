using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Voltron.Client.Models;
using Voltron.Client.Services;

namespace Voltron.Client.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseFieldNumberController
    {
        [HttpGet("[action]")]
        public DatabaseField DBFinder(int id)
        {
            var dbFieldService = new DatabaseFieldRequests();
            var field = dbFieldService.GetDatabaseField(id);
            return field;
        }

        [HttpPost("[action]")]
        public void DBFieldNumberRequest(){

        }
    }
}
