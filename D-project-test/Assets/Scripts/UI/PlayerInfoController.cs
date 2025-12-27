using TMPro;
using UnityEngine;
using Zenject;

public class PlayerInfoController : MonoBehaviour
{
    [Inject(Id = ZenjectID.PlayerNameText)]
    private TMP_Text txt_PlayerName;

    [Inject(Id = ZenjectID.HealthText)]
    private TMP_Text txt_PlayerHealth;

    private PlayerInfoView view;

    public void Initialize(string playerName, int playerHeath)
    {
        view = new(txt_PlayerName, txt_PlayerHealth);

        view.SetName(playerName);
        view.SetHealth(playerHeath.ToString());
    }
}