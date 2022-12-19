using TeamCreationV2.Core.Entites;
using TeamCreationV2.Services.Interfaces.Services.Base;

namespace TeamCreationV2.Services.Interfaces.Services
{
    public interface IPersonServices : IBaseServices<Persons>
    {
        Task<Persons> GetPersonById(int Id);
        Task<IEnumerable<Persons>> GetAllPersons();
        Task<Persons> GetOneByName(string personName);
        Task<IEnumerable<Persons>> GetAllByName(string personName);

        //Task<List<Persons>> GetAllPersonsByTeam(int id);
    }
}
