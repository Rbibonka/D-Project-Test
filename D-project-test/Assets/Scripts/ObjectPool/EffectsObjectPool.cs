public class EffectsObjectPool : BaseObjectPool<PoolableObject>
{
    public EffectsObjectPool(PoolableObject poolableObject, int startObjectPoolSize = 1)
        : base(poolableObject, startObjectPoolSize) { }
}