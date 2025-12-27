using TMPro;
using UnityEngine;
using Zenject;

public class UIBindingInstaller : MonoInstaller
{
    [SerializeField]
    private TMP_Text txt_PlayerName;

    [SerializeField]
    private TMP_Text txt_PlayerHealth;

    public override void InstallBindings()
    {
        Container.Bind<TMP_Text>().WithId(ZenjectID.PlayerNameText)
            .FromInstance(txt_PlayerName);

        Container.Bind<TMP_Text>().WithId(ZenjectID.HealthText)
            .FromInstance(txt_PlayerHealth);
    }
}