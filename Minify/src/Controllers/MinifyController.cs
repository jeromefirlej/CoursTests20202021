using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Minify.Model;

namespace Minify.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MinifyController : ControllerBase
    {
        [HttpPost]
        public string Add([FromBody] MinifyData data)
        {
            return string.Empty;
        }

        [HttpGet]
        public IEnumerable<MinifyData> Get()
        {
            return new []{
                new MinifyData{
                    Key = Guid.NewGuid().ToString(),
                    Url = "https://www.google.com"
                }            };
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}