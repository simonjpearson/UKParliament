using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using UKParliament.CodeTest.Data;
using UKParliament.CodeTest.Services;

namespace UKParliament.CodeTest.Web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        /// Change Log:
        /// simonjpearson | 06 Nov, 2021 | Implement API using standard http verbs for CRUD

        private readonly IPersonService _person;

        public PersonController(IPersonService person)
        {
            _person = person;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> Index()
        {
            return await _person.Index<Person>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> Details(int id)
        {

            var model = await _person.Details<Person>(id);
            if (model == null)
            {
                return NotFound();
            }
            return model;

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Person>> UpdateAsync(int id, Person model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }
            await _person.UpdateAsync<Person>(model);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Person>> CreateAsync([FromBody] Person model)
        {
            await _person.CreateAsync<Person>(model);
            return CreatedAtAction("Person", new { id = model.Id }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Person>> DeleteMember(int id)
        {
            var model = await _person.Details<Person>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _person.DeleteAsync<Person>(model);

            return model;
        }

    }
}
