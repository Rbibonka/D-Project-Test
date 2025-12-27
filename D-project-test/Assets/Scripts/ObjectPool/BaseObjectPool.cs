using System.Collections.Generic;
using UnityEngine;

public class BaseObjectPool<T> : IObjectPool<T> where T : PoolableObject
{
    private T poolableObject;

    private Queue<T> objectsPool;

    public BaseObjectPool(T poolableObject, int startObjectPoolSize = 1)
    {
        this.poolableObject = poolableObject;

        objectsPool = new Queue<T>(startObjectPoolSize);

        for (int i = 0; i < startObjectPoolSize; i++)
        {
            var tempPoolableObject = CreateObject();

            objectsPool.Enqueue(tempPoolableObject);
        }
    }

    public T GetFromPool()
    {
        if (objectsPool.Count < 1)
        {
            return CreateObject();
        }

        return objectsPool.Dequeue();
    }

    public void SetToPool(T poolableObject)
    {
        objectsPool.Enqueue(poolableObject);
    }

    private T CreateObject()
    {
        var tempPoolableObject = GameObject.Instantiate(poolableObject);

        return tempPoolableObject;
    }
}