using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Controllers.v2
{
    [Route("api/users")] //https://localhost:44371/api/users?api-version=2.0
   // [ApiController]
    //[ApiVersion("2.0")]
   // [Route("api/v{version:apiVersion}/users")] //https://localhost:44371/api/v2/users
    [ApiVersion("2.0")]
    public class UsersController : ControllerBase
    {
      
        [HttpGet()]
        public IActionResult AllUsers()
        {
            List<UserV2> users = new List<UserV2>()
            {
                new UserV2
                {
                    Id=1,
                    Name="hasan"
                },
                new UserV2
                {
                    Id=2,
                    Name="hasan"
                },
                new UserV2
                {
                    Id=3,
                    Name="hasan"
                },
            };

            return Ok(users);
        }
    }
}
