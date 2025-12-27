public interface IObjectPool<T> where T : IPoolableObject
{
    T GetFromPool();

    void SetToPool(T poolableObject);
}