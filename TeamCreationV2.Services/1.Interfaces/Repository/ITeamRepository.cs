using TeamCreationV2.Core.Entites;

namespace TeamCreationV2.Infra.Interfaces
{
    public interface ITeamRepository : IBaseRepository<TeamRegistre>
    {
        TeamRegistre GetByName(string TeamName);
        Task<List<TeamRegistre>> GetAllTeams();
    }
}