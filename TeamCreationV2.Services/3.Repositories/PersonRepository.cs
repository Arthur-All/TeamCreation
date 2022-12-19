using TeamCreationV2.Core.Entites;
using TeamCreationV2.Infra.Data;
using TeamCreationV2.Infra.Interfaces;
using TeamCreationV2.Services._1.Repositories.Base;

namespace TeamCreationV2.Infra.Repositories
{
    public class PersonRepository : BaseRepository<Persons>, IPersonsRepository
    {
        public PersonRepository(AppDbContext context) : base(context){}
        public async Task<List<Persons>> GetAll()
        {
            _dbset.ToList();
            return _context.Persons.ToList();
        }
        public async Task<Persons> GetPersonById(int id)
        {
            return _context.Persons.Find(id);
        }
        public async Task<IEnumerable<Persons>> GetAllBy(string personName)
        {
            var collection = _context.Persons.Where(x => x.Name.Contains(personName)).ToList();
            return collection;
        }
        public async Task<Persons> GetOneByName(string personName)
        {
            var result = _context.Persons.FirstOrDefault(x => x.Name.Equals(personName));
            return result;
        }
    }
}               /*Em progresso*/
        // public async Task<List<Persons>> GetAllPersonsByTeam(int Id)
        // {
        //return _context.Persons.Where(x => x.TeamRegistre == Id).ToList();        
        //}
