namespace TeamCreationV2.Services.Interfaces.Services.Base
{
    public interface IBaseServices<T> where T : class
    {
        Task<int> Add(T entite);
        Task<int> Remove(T entite);
    }
}
