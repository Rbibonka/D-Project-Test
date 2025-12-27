using System;

public interface IPoolableObject
{
    event Action<PoolableObject> Released;

    void Activate();

    void Deactivate();
}