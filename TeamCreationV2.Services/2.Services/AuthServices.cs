using TeamCreationV2.Infra.Interfaces;

namespace TeamCreationV2.Services.Services
{
    public class AuthServices// : IAuthServices
    {
        private readonly IPersonsRepository _personsRepository;

        public AuthServices(IPersonsRepository personsRepository)
        {
            _personsRepository = personsRepository;
        }

        /*public Task<Persons> Authenticate(PersonLogin personlogin)
        {
        }*/
    }
}
