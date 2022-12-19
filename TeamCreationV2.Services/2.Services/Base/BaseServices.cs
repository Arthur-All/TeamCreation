using TeamCreationV2.Infra.Interfaces;
using TeamCreationV2.Services.Interfaces.Services.Base;

namespace TeamCreationV2.Services._2.Services.Base
{
    public class BaseServices<T, TRepository> : IBaseServices<T> where T : class where TRepository : IBaseRepository<T>
    {
        protected readonly TRepository _respository;
        public BaseServices(TRepository respository)
        {
            _respository = respository;
        }
        public async Task<int> Add(T entite)
        {
            return await _respository.Add(entite);
        }
        public async Task<int> Remove(T entite)
        {
            return await _respository.Remove(entite);
        }
    }
}
