using TeamCreationV2.Core.Entites;
using TeamCreationV2.Services._1.Repositories.Base;

namespace TeamCreationV2.Infra.Interfaces
{
    public interface IPersonsRepository : IBaseRepository<Persons>
    {
        Task<List<Persons>> GetAll();                  
        Task<Persons> GetPersonById(int id);
        Task<IEnumerable<Persons>> GetAllBy(string personName); //Return a list of people with the same name
        Task<Persons> GetOneByName(string personName);     //Return ONE person by the name (Firstor DF)
        
        //Task<List<Persons>> GetAllPersonsByTeam(int Id); /*In progress*/
    } 
}