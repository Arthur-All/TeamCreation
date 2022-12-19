using TeamCreationV2.Core.Entites;
using TeamCreationV2.Infra.Interfaces;
using TeamCreationV2.Services._2.Services.Base;
using TeamCreationV2.Services.Interfaces.Services;

namespace TeamCreationV2.Services.Services
{
    public class TeamServices : BaseServices<TeamRegistre, ITeamRepository>, ITeamServices
    {
        
        public TeamServices(ITeamRepository teamRepository) : base(teamRepository)
        {
        }

        public async Task<int> Add(TeamRegistre team)
        {
            var result =  _respository.GetByName(team.Name);
            
            if(result == null)
            {
                _respository.Add(team);
                return 1;
            }
           return 0;

        }

        public TeamRegistre GetByName(string TeamName)
        {
            var result = _respository.GetByName(TeamName);
            if (result != null)
            {
                return _respository.GetByName(TeamName);

            }
            throw new Exception();

        }

        public async Task<List<TeamRegistre>> GetAllTeams()
        {
            return await _respository.GetAllTeams();
        }

    }
}
