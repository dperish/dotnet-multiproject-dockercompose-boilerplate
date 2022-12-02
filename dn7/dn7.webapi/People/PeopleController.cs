using System;
using System.Net;
using dn7.db;
using dn7.domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dn7.webapi.People
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly Dn7Context _context;

        public PeopleController(Dn7Context context)
        {
            _context = context;
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> Get()
        {
            var persons = await _context.Persons.Where(x => x.Id > 0).ToListAsync();
            return Ok(persons);
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> Get(int id)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);

            return person != null ? person : NotFound();
        }

        // POST api/<PeopleController>
        [HttpPost]
        public async Task<ActionResult<Person>> Post([FromBody] Person value)
        {
            var person = await _context.Persons.AddAsync(value);
            await _context.SaveChangesAsync();
            return person.Entity;
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
