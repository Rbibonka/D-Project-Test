using UnityEngine;
using Zenject;

public class EffectsCreator : IEffectPlayer
{
    [Inject]
    private IObjectPool<PoolableObject> effectsObjectPool;

    public void PlayEffect(Vector3 position)
    {
        var effect = effectsObjectPool.GetFromPool();

        effect.transform.position = position;
        effect.Released += OnEffectReleased;
        effect.Activate();
    }

    private void OnEffectReleased(PoolableObject poolableObject)
    {
        poolableObject.Released -= OnEffectReleased;
        poolableObject.Deactivate();

        effectsObjectPool.SetToPool(poolableObject);
    }
}