namespace TeamCreationV2.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> Add(T entite);
        Task<int> Remove(T entite);    
    }
}