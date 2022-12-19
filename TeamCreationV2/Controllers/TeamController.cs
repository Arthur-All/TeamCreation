using Microsoft.AspNetCore.Mvc;
using TeamCreationV2.Core.Entites;
using TeamCreationV2.Services.Interfaces.Services;

namespace TeamCreationV2.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private readonly ITeamServices _teamService;
        public TeamController(ITeamServices teamService)
        {
            _teamService = teamService;
        }

        [HttpPost("Add")]
        public async Task<ActionResult> AddTeam([FromBody] TeamRegistre team)
        {
            try
            {
                var AddedTeam = await _teamService.Add(team);
                return Created("Team registred", AddedTeam);
            }
            catch(Exception ex)
            {
                 throw ex;
            }

        }

        [HttpGet("GetByName")] 
        public async Task<ActionResult> GetByName(string TeamName)
        {
            try
            {
                var team = _teamService.GetByName(TeamName);
                return Ok(team);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet(template: ("GetAllTeams"))]
        public async Task<ActionResult<List<TeamRegistre>>> GetAllTeams()
        {
            try
            {
                var team = await _teamService.GetAllTeams();
                return Ok(team);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("RemoveTeam")]
        public async Task<ActionResult> RemoveTeam(TeamRegistre team)
        {
            try
            {
                _teamService.Remove(team);
                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
