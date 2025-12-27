using System.Collections;
using UnityEngine;

public class Effect : PoolableObject
{
    [SerializeField]
    private new ParticleSystem particleSystem;

    private Coroutine waiter;

    public override void Activate()
    {
        base.Activate();

        particleSystem.Play();

        waiter = StartCoroutine(WaitForEndEffect());
    }

    public override void Deactivate()
    {
        base.Deactivate();

        if (waiter != null)
        {
            StopCoroutine(waiter);
            waiter = null;
        }
    }

    private IEnumerator WaitForEndEffect()
    {
        yield return new WaitUntil(() => !particleSystem.IsAlive());

        OnReleased();
    }
}