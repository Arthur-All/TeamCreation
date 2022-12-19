using TeamCreationV2.Core.Entites;
using TeamCreationV2.Infra.Data;
using TeamCreationV2.Infra.Interfaces;
using TeamCreationV2.Services._1.Repositories.Base;

namespace TeamCreationV2.Infra.Repositories
{
    public class TeamRepository : BaseRepository<TeamRegistre>, ITeamRepository
    {
        public TeamRepository(AppDbContext context) : base(context) {}
        public TeamRegistre GetByName(string TeamName)
        {
            return _context.Teams.FirstOrDefault(t => t.Name == TeamName);
        }
        public async Task<List<TeamRegistre>> GetAllTeams()
        {
            return _context.Teams.ToList();
        }
    }  
}