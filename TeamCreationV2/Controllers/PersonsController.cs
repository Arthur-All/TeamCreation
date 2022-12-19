using Microsoft.AspNetCore.Mvc;
using TeamCreationV2.Core.Entites;
using TeamCreationV2.Services.Interfaces.Services;

namespace TeamCreationV2.Controllers
{
    [Route("api/[controller]")]

    public class PersonsController : Controller
    {
        private readonly IPersonServices _personService;
        public PersonsController(IPersonServices personService)
        {
            _personService = personService;
        }

        [HttpPost("AddPerson")]
        public async Task<ActionResult> AddPerson([FromBody] Persons person)
        {
            try
            {
                var AddedPerson = await _personService.Add(person);
                return Created("person registred", AddedPerson);
            }
            
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet("GetAllByName")]
        public async Task<ActionResult<IEnumerable<Persons>>> GetAllByName(string personName)
        {
            try
            {
                var result =  await _personService.GetAllByName(personName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetOneByName")]
        public async Task<ActionResult<Persons>> GetOneByName(string personName)
        {
            try
            {
                var result = await _personService.GetOneByName(personName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetPersonById")]
        public async Task<ActionResult<Persons>> GetPersonById(int id)
        {
            try
            {
                var result = await _personService.GetPersonById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet(template: ("GetAll"))]
        public async Task<ActionResult<List<TeamRegistre>>> GetAllPersons()
        {
            try
            {
                var person = await _personService.GetAllPersons();
                return Ok(person);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("Remove")]
        public async Task<ActionResult> RemoveTeam(Persons person)
        {
            try
            {
                var remove = await _personService.Remove(person);
                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
         