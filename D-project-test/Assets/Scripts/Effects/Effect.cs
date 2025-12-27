using UnityEngine;

public class Effect : PoolableObject
{
    [SerializeField]
    private new ParticleSystem particleSystem;

    private void Awake()
    {
        var mainModule = particleSystem.main;
        mainModule.stopAction = ParticleSystemStopAction.Callback;
    }

    public override void Activate()
    {
        base.Activate();

        particleSystem.Play();
    }

    public override void Deactivate()
    {
        base.Deactivate();
    }

    private void OnParticleSystemStopped()
    {
        OnReleased();
    }
}