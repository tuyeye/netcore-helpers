using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using yournamespace.helper;

namespace yournamespace.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class yourControllers : ControllerBase
    {
        private readonly IDatabase _redis;
        public yourControllers(RedisHelper client)
        {
            _redis = client.GetDatabase();
        }

        [HttpGet("test")]
        public void Test()
        {
            _redis.StringGet("test").ToString();
            _redis.StringSet("test2","test2");
        }
    }
}
