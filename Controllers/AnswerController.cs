using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using pollService.DataAccess;

namespace pollService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] Quiz value)
        {

            var jsonString = JsonConvert.SerializeObject(value);
            return Ok(new
            {
                message = "Contact is added successfully."
            });
        }
    }
}