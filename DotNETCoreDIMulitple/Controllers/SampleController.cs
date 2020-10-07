using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreDIMultiple.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNETCoreDIMultiple.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        private readonly IEnumerable<ISample> _samples;

        public SampleController(IEnumerable<ISample> samples)
        {
            _samples = samples;
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            var sample = this._samples.FirstOrDefault(item => item.Name == name);
            if (sample != null)
            {
                return Ok(sample.GetName());
            }
            return BadRequest();
        }
    }
}
