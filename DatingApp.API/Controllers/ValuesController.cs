using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext context { get; set; }
        public ValuesController(DataContext context)
        {
            this.context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> GetValues()
        {
            var reposne = await this.context.Value.ToListAsync();
            return Ok(reposne);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            var reposne = await this.context.Value.FirstOrDefaultAsync(x=>x.Id == id);
            return Ok(reposne);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
