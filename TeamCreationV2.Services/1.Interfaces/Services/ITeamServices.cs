using TeamCreationV2.Core.Entites;
using TeamCreationV2.Services.Interfaces.Services.Base;

namespace TeamCreationV2.Services.Interfaces.Services
{
    public interface ITeamServices : IBaseServices<TeamRegistre>
    {
        TeamRegistre GetByName(string TeamName);
        Task<List<TeamRegistre>> GetAllTeams();
        
    }
}
