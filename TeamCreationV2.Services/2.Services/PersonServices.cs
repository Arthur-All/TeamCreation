using TeamCreationV2.Core.Entites;
using TeamCreationV2.Infra.Interfaces;
using TeamCreationV2.Services._2.Services.Base;
using TeamCreationV2.Services.Interfaces.Services;

namespace TeamCreationV2.Services.Services
{
    public class PersonServices : BaseServices<Persons, IPersonsRepository>, IPersonServices
    {
        public PersonServices(IPersonsRepository personsRepository) : base(personsRepository)
        {
        }

        public async Task<IEnumerable<Persons>> GetAllPersons()
        {
            return await _respository.GetAll();
        }

        public async Task<Persons> GetPersonById(int Id)
        {
            var result = await _respository.GetPersonById(Id);
            if(result != null)
            {
                return await _respository.GetPersonById(result.Id);

            }return null;
        }

        public async Task<Persons> GetOneByName(string personName)
        {            
           var result = await _respository.GetOneByName(personName);
            if (result != null)
            {
                return result;

            }return null;
        }
        public async Task<IEnumerable<Persons>> GetAllByName(string personName)
        {
            return await _respository.GetAllBy(personName);
        }


        // public async Task<List<Persons>> GetAllPersonsByTeam(int id)
        //{
        //    return await _personsRepository.GetAllPersonsByTeam(id);
        //}

        
    }
}
