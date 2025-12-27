using System;
using UnityEngine;

public class PoolableObject : MonoBehaviour, IPoolableObject
{
    public event Action<PoolableObject> Released;

    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }

    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public void OnReleased()
    {
        Released?.Invoke(this);
    }
}