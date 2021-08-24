using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Controllers.v1
{
    [Route("api/v{version:apiVersion}/users")]
    [ApiController]
    [ApiVersion("1.0",Deprecated =true)]
    public class UsersController : ControllerBase
    {
        [HttpGet()]
        public IActionResult AllUsers()
        {
            List<UserV1> users = new List<UserV1>()
            {
                new UserV1
                {
                    Id=1,
                    Name="asya"
                },
                new UserV1
                {
                    Id=2,
                    Name="asya2"
                },
                new UserV1
                {
                    Id=3,
                    Name="asya3"
                },
            };

            return Ok(users);
        }















    }
}
