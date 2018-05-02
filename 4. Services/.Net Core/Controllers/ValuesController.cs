using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NerdyGuy.Services.NetCore.Example.Controllers
{
    [Authorize]
    [Route("api")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("values")]
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }        
    }
}
