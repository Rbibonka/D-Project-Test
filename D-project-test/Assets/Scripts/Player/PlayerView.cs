using UnityEngine;

public class PlayerView
{
    private IEffectPlayer effectPlayer;

    public PlayerView(IEffectPlayer effectPlayer)
    {
        this.effectPlayer = effectPlayer;
    }

    public void PlayEffect(Vector3 position)
    {
        effectPlayer.PlayEffect(position);
    }
}